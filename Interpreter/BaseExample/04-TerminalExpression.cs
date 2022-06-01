namespace InterpreterPattern {
	class TerminalExpression : AbstractExpression {

		protected int _value = 0;

		public TerminalExpression(int value) => _value = value;

		public override int Interpret(Context context) => _value;

	}
}
