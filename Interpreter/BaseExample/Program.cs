namespace InterpreterPattern {
	class MainClass {
		public static void Main (string[] args){

			Context context = new Context();

			AbstractExpression tree = 
				new NonterminalExpression (
					new TerminalExpression (4),
					new TerminalExpression (3)
				);
			
			int result = tree.Interpret(context);

			System.Console.WriteLine(context.Operation + ": " + result);
			
			// Sum: 4 + 3

		}
	}
}
