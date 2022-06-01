namespace FoodchainExample {

	class Lion : Carnivore {
		public override void Eat (Herbivore herbivore)
			=> System.Console.WriteLine("{0} eats {1}", this.GetType().Name, herbivore.GetType().Name);
	}

}
