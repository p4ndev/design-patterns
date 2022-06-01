namespace InterpreterPattern{
	class NonterminalExpression : AbstractExpression{

		protected AbstractExpression _lhs = null;
		protected AbstractExpression _rhs = null;

		public NonterminalExpression(AbstractExpression lhs, AbstractExpression rhs){
			_lhs = lhs;
			_rhs = rhs;
		}

		public override int Interpret(Context context)
			=> _lhs.Interpret(context) + _rhs.Interpret(context);
	}
}
