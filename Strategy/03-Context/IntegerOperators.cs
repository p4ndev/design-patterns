namespace StrategyPattern{
    public class IntegerOperators{

        private Calculator? _strategy;

        public IntegerOperators SetStrategy(Calculator strategy) {
            _strategy = strategy;
            return this;
        }

        public int Calc() => _strategy!.Execute();

    }
}
