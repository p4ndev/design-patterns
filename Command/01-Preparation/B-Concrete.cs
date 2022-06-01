namespace CommandPattern{
	public class ConcreteCommand : Command{

		public ConcreteCommand(Receiver receiver) :	base(receiver) {
			System.Console.WriteLine("New command created");
		}

		public override void Execute() {
			System.Console.WriteLine("Command.Execute() called");
			receiver.Action();
		}

	}	
}
