using StrategyPattern;
using static System.Console;

IntegerOperators op = new();
Calculator any;

// ============= SOMA =============

any = new SumStrategy(10, 20);

WriteLine(
    "Somando: 10 + 20 = {0}",
    op.SetStrategy(any).Calc()
);

// =========== SUBTRACT ===========

any = new SubtractStrategy(30, 10);

WriteLine(
    "Subtraindo: 30 - 10 = {0}",
    op.SetStrategy(any).Calc()
);