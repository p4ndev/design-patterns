using System;

namespace ToyFactoryExample {
	class MainClass {
		public static void Main (string[] args) {
			
			ToyCreator creator = null;

			// Create a firetruck
			Console.WriteLine ("Creating a firetruck toy:");
			creator = new FiretruckCreator();
			creator.MakeToy();
			Console.WriteLine ();

			// Create a superman
			Console.WriteLine ("Creating a superman toy:");
			creator = new SupermanCreator();
			creator.MakeToy();
			Console.WriteLine();

		}
	}
}
