namespace MathExample.Expression{
    public class DivideTerminal : Abstraction.MathExpression {

        public DivideTerminal(int value) : base(value) { }

        public override void Interpret(Context.Wrapper context)
            => context.Value /= base.innerValue;

        public override string Signal() => "/";

    }
}