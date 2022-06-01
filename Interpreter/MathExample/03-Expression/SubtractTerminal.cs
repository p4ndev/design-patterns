namespace MathExample.Expression{
    public class SubtractTerminal : Abstraction.MathExpression {

        public SubtractTerminal(int value) : base(value) { }

        public override void Interpret(Context.Wrapper context)
            => context.Value -= base.innerValue;

        public override string Signal() => "-";
    }
}