using System;
using System.Drawing;

namespace ToyFactoryExample {

	class Superman : Toy {

		public override int GetPowderQuantity() => 20;

		public override TimeSpan GetHeatingTime() => TimeSpan.FromMinutes(1);

		public override Color GetColor() => Color.Blue;

	}

}
