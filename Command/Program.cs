namespace CommandPattern{
	class MainClass	{
		public static void Main (string[] args)	{

			// Preparation			
			Invoker  i = new Invoker();
			Receiver r = new Receiver();

			// Implementation
			Command  c = new ConcreteCommand(r);

			// Calling
			i.Invoke(c);

		}
	}
}
