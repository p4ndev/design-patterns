namespace PurchaseOrderingExample {
	class VicePresident : POApprover {

		public VicePresident(POApprover successor) => _successor = successor;

		public override void Success(decimal price) {
            if (price <= 25000)
                System.Console.WriteLine("${0} purchase approved by Vice Presidents", price);
        }

        public override void Fail(decimal price)
            => _successor.ProcessRequest(price);

	}
}
