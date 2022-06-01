namespace FoodchainExample {

	class AustraliaFactory : ContinentFactory{
		public override Herbivore CreateHerbivore() => new Kangaroo();
		public override Carnivore CreateCarnivore() => new Dingo();
	}

}
