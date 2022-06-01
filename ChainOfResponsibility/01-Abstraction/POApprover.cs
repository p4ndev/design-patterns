namespace PurchaseOrderingExample {
	public abstract class POApprover {

		protected POApprover _successor;

		public abstract void Success(decimal price);
		public abstract void Fail(decimal price);
		
		public void ProcessRequest(decimal price) {
			Success(price);
			Fail(price);
		}

	}
}
