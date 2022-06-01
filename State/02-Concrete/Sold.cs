using System;

namespace VendingMachineExample{
	public class Sold : State{

		public override void InsertCoin (VendingMachine context)
			=> CommonMessage("You cannot eject a coin while the machine is dispensing");

		public override void EjectCoin (VendingMachine context)
			=> CommonMessage("You cannot eject a coin while the machine is dispensing");

		public override void PushButton(VendingMachine context)
			=> CommonMessage("You cannot press the button a second time");

		public override void DispenseChocolate (VendingMachine context)	{
			context.Products--;

			if (context.Products > 0)
				context.State = new NoCoin();
			else
				context.State = new SoldOut();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("Chocolate bar dispensed");
		}

		private void CommonMessage(string msg) {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(msg);
		}

	}
}
