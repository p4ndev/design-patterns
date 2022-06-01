namespace DocumentEditorExample{
	public class Document{

		private sealed class DocumentState{

			private string _state;

			public string State { get => _state; }

			public DocumentState(string state) => _state = state;

		}

		private string _html;
		
		public override string ToString()		=> _html;

		public void Append(string text)			=> _html += text;

		public void Italic()					=> _html = "<i>" + _html + "</i>";

		public void Bold()						=> _html = "<b>" + _html + "</b>";

		public object SaveState()				=> new Document.DocumentState(_html);

		public void LoadState(object docstate)	=> _html = (docstate as DocumentState).State;

	}
	
}
