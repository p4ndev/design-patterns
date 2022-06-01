using System;

namespace VendingMachineExample{
	public class NoCoin : State{

		public override void InsertCoin(VendingMachine context){
			if (context.Products > 0){
				context.State = new CoinInserted ();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine ("Coin accepted");
			} else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine ("Sold out");
			}
		}

		public override void EjectCoin(VendingMachine context){
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Cannot eject coin because no coin was inserted");
		}

		public override void PushButton(VendingMachine context){
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Pushing the button does nothing because no coin was inserted");
		}

		public override void DispenseChocolate(VendingMachine context)	{ }

	}
}
