namespace PurchaseOrderingExample {
	class Manager : POApprover {

		public Manager(POApprover successor) => _successor = successor;

        public override void Success(decimal price) {
            if (price <= 10000)
                System.Console.WriteLine("${0} purchase approved by Managers", price);
        }

        public override void Fail(decimal price)
            => _successor.ProcessRequest(price);

    }
}
