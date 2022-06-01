using System;

namespace DocumentEditorExample{
	class MainClass{

		private static void FlushDocument(string text, Document document){

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(document);

		}

		public static void Main (string[] args){

			var document = new Document();
			var history	 = new History(document);

			history.Snapshot();
			document.Append("The quick brown fox jumped over the lazy dog");
			history.Snapshot();
			document.Italic();
			history.Snapshot();
			document.Bold();
			FlushDocument("Initial document:", document);

			history.Restore(1);
			FlushDocument("Document restored to record #1:", document);

			history.Restore(2);
			FlushDocument("Document restored to record #2:", document);

		}

	}
}
