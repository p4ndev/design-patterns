namespace StrategyPattern{
    public abstract class Calculator {

        protected int Left { get; set; }
        protected int Right { get; set; }

        public Calculator(int left, int right){
            Left = left;
            Right = right;
        }

        public abstract int Execute();

    }
}
