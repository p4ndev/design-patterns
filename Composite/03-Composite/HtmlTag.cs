using System.Collections.Generic;
using System.Text;

namespace HtmlRenderExample{	
	public abstract class HtmlTag : HtmlNode {
		
		protected string _tagName					= null;
		private readonly StringBuilder _builder		= new StringBuilder();
		protected List<HtmlNode> _elements			= new List<HtmlNode>();
		protected HtmlTag(string tagName)			=> _tagName = tagName;
		public void AddChild(HtmlNode component)	=> _elements.Add(component);

		private void Header()	=> _builder.AppendFormat("<{0}>", _tagName);
		private void Content()	=> _elements.ForEach(child => _builder.Append(child.Render()));
		private void Footer()	=> _builder.AppendFormat("</{0}>", _tagName);

		public override string Render() {
			
			Header();
			Content();
			Footer();
			
			return _builder.ToString();

		}
		
	}	
}
