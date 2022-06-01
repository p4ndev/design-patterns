namespace ToyFactoryExample{
	class FiretruckCreator : ToyCreator{
		protected override Toy CreateToy() => new Firetruck();
	}
}