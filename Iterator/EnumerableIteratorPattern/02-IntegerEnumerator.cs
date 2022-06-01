using System.Collections;

namespace EnumerableIteratorPattern;

public class IntegerEnumerator : IEnumerator<int> {

	private int _current = -1;

	private IntegerCollection _enumerable;

	public IntegerEnumerator(IntegerCollection enumerable)
		=> this._enumerable = enumerable;

	public void Reset() => _current = -1;

	public bool MoveNext() {
		if (_current <= 2) _current++;
		return _current < 2;
	}

	object IEnumerator.Current {
		get => Current;
	}
	
	public int Current {
		get => _current switch {
			0 => _enumerable.fieldA,
			1 => _enumerable.fieldB,
			_ => throw new IndexOutOfRangeException(),
		};
	}

	public void Dispose() { }

}
