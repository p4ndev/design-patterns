using System;

namespace MyCollectionExample{
	class MainClass{
		public static void Main (string[] args){

			ConcreteAggregate a = new ConcreteAggregate();

			a[0] = "Item A";
			a[1] = "Item B";
			a[2] = "Item C";

			Iterator i = a.CreateIterator();

			object item = i.First();
			
			while (item != null){
				Console.WriteLine(item);
				item = i.Next();
			}

		}
	}
}
