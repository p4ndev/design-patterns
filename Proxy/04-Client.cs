using System.Threading;
using System;

namespace BitcoinExample {	
	public class Client {
		public void Execute () {
			
			string msg = "";
			var service = new WithRateLimit(new BitcoinApi());

			for (int i = 0; i < 21; i++) {	
				try {
					msg = service.GetValueInUSD().ToString();
				} catch(Exception ex) {
					msg = ex.Message;
				} finally {
					Console.WriteLine(msg);
				}
				Thread.Sleep(100);
			}

		}
	}
}

