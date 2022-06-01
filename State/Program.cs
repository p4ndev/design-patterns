using System;

namespace VendingMachineExample {
	class MainClass{		
		public static void Main (string[] args){
			
			var machine = new VendingMachine();

			Console.WriteLine ("Vending machine commands");
			Console.WriteLine ("1: Insert coin");
			Console.WriteLine ("2: Eject coin");
			Console.WriteLine ("3: Push button");
			Console.WriteLine ("4: Quit");

			while (true){				
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Enter command: ");
				string command = Console.ReadLine();

				if (command == "4")							break;

				switch (command) {
					case "1":	machine.InsertCoin();		break;
					case "2":	machine.EjectCoin();		break;
					case "3":	machine.PushButton();		break;
				}
			}

		}
	}
}
