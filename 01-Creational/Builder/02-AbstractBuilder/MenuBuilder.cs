namespace Builder{
    public abstract class MenuBuilder{

        public abstract Menu GetResult();
        public abstract void Build();

        protected void AddHamburger()   => GetResult().Add("Burger");
        protected void AddFries()       => GetResult().Add("Fries");
        protected void AddDessert()     => GetResult().Add("Dessert");
        protected void AddDrink()       => GetResult().Add("Drink");
        protected void AddToy()         => GetResult().Add("Toy");
        protected void AddSalad()       => GetResult().Add("Salad");

    }
}
