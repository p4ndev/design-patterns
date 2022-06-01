using System;

namespace PizzaRestaurantExample{
	class MainClass{
		public static void Main (string[] args){

			var margarita = new Margarita();

			// ===============================================================
			// ====================== Scenario 1 =============================
			// ===============================================================

			var margaritHam = new WithExtraHam(margarita);
			Console.WriteLine(margaritHam.GetPrice());

			// ===============================================================
			// ====================== Scenario 2 =============================
			// ===============================================================

			var margaritaCheeseAndHam = new WithExtraCheese(margaritHam);
			Console.WriteLine(margaritaCheeseAndHam.GetPrice());

		}
	}
}
