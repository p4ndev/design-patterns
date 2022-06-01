using System;
using System.Drawing;

namespace ToyFactoryExample{

	class Firetruck : Toy {

		public override int GetPowderQuantity() => 40;

		public override TimeSpan GetHeatingTime() => TimeSpan.FromMinutes(2);

		public override Color GetColor() => Color.Red;

	}

}
