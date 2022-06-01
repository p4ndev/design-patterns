namespace ProductCatalogExample{
	public class Book : Product{
		public override void Accept(Visitor visitor) => visitor.Visit(this);
	}
}
