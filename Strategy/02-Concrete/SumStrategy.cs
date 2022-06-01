namespace StrategyPattern{
    public class SumStrategy : Calculator{

        public SumStrategy(int left, int right) : base(left, right) { }

        public override int Execute() => base.Left + base.Right;

    }
}
