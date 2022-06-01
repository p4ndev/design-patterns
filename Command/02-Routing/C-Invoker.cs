namespace CommandPattern{
	public class Invoker{

		public void Invoke(Command command)	{
			System.Console.WriteLine ("Invoker.Invoke(command) called");
			command.Execute();
		}

	}
}
