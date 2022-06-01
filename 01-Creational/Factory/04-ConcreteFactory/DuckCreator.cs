namespace ToyFactoryExample{
	class DuckCreator : ToyCreator{
		protected override Toy CreateToy() => new Duck();
	}
}