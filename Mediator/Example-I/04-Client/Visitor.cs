using System;

namespace ChatroomExample{
	public class Visitor : AbstractVisitor{

		public Visitor(string name) => this._name = name;

		public override void Receive(string message){
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("{0} <-- {1}", _name, message);
		}

	}
}
