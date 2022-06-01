using System;

namespace ProductCatalogExample{
	class MainClass{
		public static void Main (string[] args)	{

			var catalog		= new Catalog();
			var partitioner = new ProductPartitioner();

				catalog.Add(new Book());
				catalog.Add(new Book());
				catalog.Add(new Book());
				catalog.Add(new Book());

				catalog.Add(new Movie());
				catalog.Add(new Movie());
				catalog.Add(new Movie());

				catalog.Add(new Toy());
				catalog.Add(new Toy());

				catalog.Add(new Clothing());

			catalog.Accept(partitioner); // Entrypoint

			Console.WriteLine("{0} books",		partitioner.Books);
			Console.WriteLine("{0} movies",		partitioner.Movies);
			Console.WriteLine("{0} toys",		partitioner.Toys);
			Console.WriteLine("{0} clothing",	partitioner.Clothing);

		}
	}
}
