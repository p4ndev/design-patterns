namespace PurchaseOrderingExample {
	public class POClient {

		protected POApprover approvalChain = null;

		public POClient() => approvalChain = new Manager(new VicePresident(new CEO(null)));

		public void ProcessRequest(decimal price) => approvalChain.ProcessRequest(price);

	}
}

