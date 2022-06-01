using MathExample.Abstraction;
using MathExample.Expression;
using MathExample.Context;

var ctx = new Wrapper();

List<MathExpression> lst = new() {
    new SumTerminal(10),
    new SumTerminal(50),
    new DivideTerminal(2),
    new MultiplyTerminal(4),
    new SubtractTerminal(10)
};

lst.ForEach(i => {

    i.Interpret(ctx);

    Console.WriteLine(
        "{0} {1} and result is {2}",
        i.Signal(), i.GetType().Name, ctx.Value
    );

});

Console.ReadKey();