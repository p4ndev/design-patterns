using System;

namespace VendingMachineExample{
	public class CoinInserted : State{

		public override void InsertCoin(VendingMachine context){
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("You cannot insert a second coin");
		}

		public override void EjectCoin(VendingMachine context){
			context.State = new NoCoin ();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("Coin returned");
		}

		public override void PushButton(VendingMachine context) 
			=> context.State = new Sold();

		public override void DispenseChocolate(VendingMachine context){
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("You must press the button first");
		}

	}
}
