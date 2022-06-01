namespace MathExample.Abstraction{
    public abstract class MathExpression {
        protected int innerValue = 0;
        public MathExpression(int value) => innerValue = value;
        public abstract void Interpret(Context.Wrapper context);
        public abstract string Signal();
    }
}
