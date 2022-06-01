using System.Collections;

namespace EnumerableIteratorPattern;

public class IntegerCollection : IEnumerable<int>{

	internal int fieldA = 0, fieldB = 0;

	public IntegerCollection(int a, int b){
		fieldA = a;
		fieldB = b;
	}

	// 1) Entrypoint for FOREACH statement (called in the future)
	IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

	// 2) Collect everything's data
	// 3) Send to an implementation of the .Net Enumerator
	// 4) Implement/Override all .NET requirements
	// 5) Return here as a complete iterable object
	public IEnumerator<int> GetEnumerator() => new IntegerEnumerator(this);

}
