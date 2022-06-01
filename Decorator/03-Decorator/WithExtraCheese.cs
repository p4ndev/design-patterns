namespace PizzaRestaurantExample{
	class WithExtraCheese : PizzaTopping{

		public WithExtraCheese(PizzaElement component) : base (component){}

		public override decimal GetPrice() => base.GetPrice() + 1m;

	}	
}
