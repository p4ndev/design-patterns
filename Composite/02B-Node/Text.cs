namespace HtmlRenderExample {
	public class Text : LeafNode {		
		protected string _text			= null;
		public override string Render() => _text;
		public Text(string text)		=> _text = text;
	}
}

