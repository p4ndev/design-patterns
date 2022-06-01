namespace PurchaseOrderingExample {
	class MainClass {
		public static void Main (string[] args)	{

			var poSystem = new POClient();

			poSystem.ProcessRequest(1000);		// Approved by Manager
			poSystem.ProcessRequest(20000);		// Approved by Vice President
			poSystem.ProcessRequest(300000);	// Approved by CEO

		}
	}
}
