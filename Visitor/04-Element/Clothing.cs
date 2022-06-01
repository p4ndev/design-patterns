namespace ProductCatalogExample{
	public class Clothing : Product{
		public override void Accept(Visitor visitor) => visitor.Visit(this);
	}
}
