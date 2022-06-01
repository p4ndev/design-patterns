namespace ToyFactoryExample{
	class SupermanCreator : ToyCreator{
		protected override Toy CreateToy() => new Superman();
	}
}