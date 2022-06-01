using EnumerableIteratorPattern;

var collection = new IntegerCollection(123, 456);

foreach (int value in collection)
    Console.WriteLine(value);