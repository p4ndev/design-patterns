using System;

namespace VendingMachineExample{
	public class SoldOut : State{
		
		public override void InsertCoin(VendingMachine context) => CommonMessage();
		public override void EjectCoin(VendingMachine context)	=> CommonMessage();
		public override void PushButton(VendingMachine context) => CommonMessage();

		public override void DispenseChocolate(VendingMachine context) { }

		private void CommonMessage() {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("The machine is sold out");
		}

	}
}
