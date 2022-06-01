namespace FoodchainExample{

	// The client class
	class Ecosystem	{
		
		// Product abstractions (future: producto)
		private Herbivore _herbivore;
		private Carnivore _carnivore;

		// The factory to use to create carnivores and herbivores,
		// based on Factory abstraction parameter
		public Ecosystem(ContinentFactory factory) {
			_herbivore = factory.CreateHerbivore();
			_carnivore = factory.CreateCarnivore();
		}

		// Let the carnivore eat the herbivore
		// no matter where there are right now
		public void Run() => _carnivore.Eat(_herbivore);
	}

}
