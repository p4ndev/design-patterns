using System;

namespace BitcoinExample{

	class WithRateLimit : Coin{

		private Coin _realSubject;

		DateTime lastCalled = DateTime.MinValue;

		public WithRateLimit(Coin realSubject) => _realSubject = realSubject;

		public override decimal GetValueInUSD() {
			if (DateTime.Now - lastCalled < TimeSpan.FromSeconds (1))
				throw new InvalidOperationException("Rate limit exceeded");
			else {
				var value = _realSubject.GetValueInUSD();
				lastCalled = DateTime.Now;
				return value;
			}
		}

	}
	
}
