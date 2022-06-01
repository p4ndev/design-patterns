namespace PizzaRestaurantExample{
	public abstract class PizzaTopping : PizzaElement {		
		protected PizzaElement _component;
		protected PizzaTopping(PizzaElement component)	=> _component = component;
		public override decimal GetPrice()				=> _component.GetPrice();
	}	
}
