using System.Collections.Generic;

namespace DocumentEditorExample{
	public class History {
		
		private Document _document = null;

		private List<object> _history = new List<object>();

		public History(Document document) => _document = document;

		public void Snapshot(){
			var memento = _document.SaveState();
			_history.Add(memento);
		}

		public void Restore(int index) {
			var memento = _history[index];
			_document.LoadState(memento);
		}

	}
}
