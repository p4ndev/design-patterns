namespace ProductCatalogExample{
	public class ProductPartitioner : Visitor{

		protected int _books = 0;
		public int Books { get => _books; }
		public override void Visit(Book product) => _books++;

		protected int _movies = 0;
		public int Movies { get => _movies; }
		public override void Visit(Movie product) => _movies++;
		
		protected int _toys = 0;
		public int Toys { get => _toys; }
		public override void Visit(Toy product) => _toys++;
		
		protected int _clothing = 0;
		public int Clothing { get => _clothing; }
		public override void Visit(Clothing product) => _clothing++;

	}	
}
