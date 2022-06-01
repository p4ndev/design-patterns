namespace Builder{
    public class SaladMenuBuilder : MenuBuilder{

        private Menu _menu = new Menu();

        public override void Build(){
            this.AddSalad();
            this.AddDessert();
            this.AddDrink();
        }

        public override Menu GetResult() => _menu;

    }
}