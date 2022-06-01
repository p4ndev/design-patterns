using System;

namespace HtmlRenderExample{
	class MainClass{
		public static void Main (string[] args)	{

			var html = new Html();
			var body = new Body();
			var p	 = new P();

			var txt = new Text("Hello World");

			p.AddChild(txt);
			body.AddChild(p);
			html.AddChild(body);

			Console.WriteLine(html.Render());

		}
	}
}
