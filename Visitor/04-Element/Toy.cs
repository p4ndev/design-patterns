namespace ProductCatalogExample{
	public class Toy : Product{
		public override void Accept(Visitor visitor) => visitor.Visit(this);
	}
}