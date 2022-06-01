namespace MathExample.Expression{
    public class SumTerminal : Abstraction.MathExpression {

        public SumTerminal(int value) : base(value) { }

        public override void Interpret(Context.Wrapper context)
            => context.Value += base.innerValue;

        public override string Signal() => "+";

    }
}