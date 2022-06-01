namespace StrategyPattern{
    public class SubtractStrategy : Calculator{

        public SubtractStrategy(int left, int right) : base(left, right) { }

        public override int Execute() => base.Left - base.Right;

    }
}
