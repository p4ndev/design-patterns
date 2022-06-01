using System;

namespace FacadePattern{
	class MainClass{
		public static void Main (string[] args){

			var facade = new Facade();

			Console.WriteLine ("Calling Facade.MethodA...");
			facade.MethodA();

			Console.WriteLine ("Calling Facade.MethodB...");
			facade.MethodB();

		}
	}
}
