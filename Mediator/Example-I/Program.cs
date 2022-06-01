namespace ChatroomExample{
	class MainClass{
		public static void Main (string[] args){

			// Real users
			var tom		= new Visitor("Tom");
			var dick	= new Visitor("Dick");
			var harry	= new Visitor("Harry");

			// Mediator
			var chatroom = new Chatroom();
			tom.Enter(chatroom);
			dick.Enter(chatroom);
			harry.Enter(chatroom);

			// Interactions
			tom.Send("Hello everyone");
			dick.Send("Welcome to the chatroom Tom");
			harry.Send("Hi Tom, nice to meet you");

		}
	}
}
