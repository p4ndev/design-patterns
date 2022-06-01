namespace FoodchainExample {

	class AfricaFactory : ContinentFactory {
		public override Herbivore CreateHerbivore() => new Zebra();
		public override Carnivore CreateCarnivore() => new Lion();
	}

}
