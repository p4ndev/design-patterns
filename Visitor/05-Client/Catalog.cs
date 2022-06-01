using System.Collections.Generic;

namespace ProductCatalogExample{
	public class Catalog{

		private List<Product> _products = new List<Product>();

		public void Add(Product product) => _products.Add(product);

		public void Accept(Visitor visitor) {
			foreach (Product product in _products)
				product.Accept(visitor);
		}

	}
}
