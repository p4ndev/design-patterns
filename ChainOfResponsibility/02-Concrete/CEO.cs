namespace PurchaseOrderingExample {
	class CEO : POApprover {

		public CEO(POApprover successor) => _successor = successor;

		public override void Success(decimal price) {
            if (price <= 100000)
                System.Console.WriteLine("${0} purchase approved by CEOs", price);
        }

        public override void Fail(decimal price)
            => System.Console.WriteLine("Plan executive meeting to approve ${0} purchase", price);

	}
}
