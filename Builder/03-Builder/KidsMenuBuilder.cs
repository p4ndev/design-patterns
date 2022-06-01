namespace Builder{
    public class KidsMenuBuilder : MenuBuilder{

        private Menu _menu = new Menu();

        public override void Build(){
            this.AddHamburger();
            this.AddFries();
            this.AddToy();
        }

        public override Menu GetResult() => _menu;

    }
}