using System;

namespace ChatroomExample{
	public abstract class AbstractVisitor{

		protected string _name = null;

		protected AbstractMediator _currentChatroom = null;

		public abstract void Receive(string message);

		public void Send(string message){
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("{0} --> {1}", _name, message);
			_currentChatroom.Send(message, this);
		}

		public void Enter(AbstractMediator chatroom){
			if (_currentChatroom != null) Leave();
			chatroom.Register(this);
			_currentChatroom = chatroom;
		}

		public void Leave(){
			if (_currentChatroom != null){
				_currentChatroom.Unregister(this);
				_currentChatroom = null;
			}
		}

	}
}
