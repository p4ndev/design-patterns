namespace PizzaRestaurantExample{
	class WithExtraHam : PizzaTopping{

		public WithExtraHam(PizzaElement component) : base(component) { }

		public override decimal GetPrice() => base.GetPrice() + 1.50m;

	}
}
