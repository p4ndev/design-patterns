namespace VendingMachineExample {
	public class VendingMachine{

		private State _state;

		private int _products = 5;

		public VendingMachine()		=> this.State = new NoCoin();

		public void InsertCoin()	=> _state.InsertCoin(this);

		public void EjectCoin()		=> _state.EjectCoin(this);

		public void PushButton (){
			_state.PushButton (this);
			_state.DispenseChocolate (this);
		}
		
		public State State {
			get => _state;
			set => _state = value;
		}

		public int Products{
			get => _products;
			set => _products = value;
		}

	}
}
