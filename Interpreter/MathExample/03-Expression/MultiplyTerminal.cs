namespace MathExample.Expression{
    public class MultiplyTerminal : Abstraction.MathExpression {

        public MultiplyTerminal(int value) : base(value) { }

        public override void Interpret(Context.Wrapper context)
            => context.Value *= base.innerValue;

        public override string Signal() => "*";

    }
}