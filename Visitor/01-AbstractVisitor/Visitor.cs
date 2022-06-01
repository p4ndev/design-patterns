namespace ProductCatalogExample{
	public abstract class Visitor{
		public abstract void Visit(Book product);
		public abstract void Visit(Movie product);
		public abstract void Visit(Toy product);
		public abstract void Visit(Clothing product);
	}	
}
