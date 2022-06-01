namespace Builder{
    public class BurgerMenuBuilder : MenuBuilder{

        private Menu _menu = new Menu();

        public override void Build(){
            this.AddHamburger();
            this.AddFries();
            this.AddDessert();
            this.AddDrink();
        }

        public override Menu GetResult() => _menu;

    }
}