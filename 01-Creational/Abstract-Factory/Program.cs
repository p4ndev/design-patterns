namespace FoodchainExample {
	class MainClass	{
		public static void Main (string[] args){
			
			// Factory & Client
			ContinentFactory factory;
			Ecosystem ecosystem;

			// Simulate ecosystem in Africa
			factory = new AfricaFactory();
			ecosystem = new Ecosystem(factory);
			ecosystem.Run();

			// Simulate ecosystem in Australia
			factory = new AustraliaFactory();
			ecosystem = new Ecosystem(factory);
			ecosystem.Run();

		}
	}
}
