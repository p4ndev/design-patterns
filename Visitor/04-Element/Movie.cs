namespace ProductCatalogExample{
	public class Movie : Product{
		public override void Accept(Visitor visitor) => visitor.Visit(this);
	}
}
