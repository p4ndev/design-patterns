namespace FacadePattern{
	class Facade{

		private SubSystemOne	_one;
		private SubSystemTwo	_two;
		private SubSystemThree	_three;

		public Facade(){
			_one	= new SubSystemOne();
			_two	= new SubSystemTwo();
			_three	= new SubSystemThree();
		}

		public void MethodA(){
			_one.MethodOne();
			_two.MethodTwo();
		}

		public void MethodB(){
			_two.MethodTwo();
			_three.MethodThree();
		}

	}	
}
