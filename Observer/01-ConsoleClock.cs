using System;

namespace TimerExample {	
	public class ConsoleClock {
		public void Update(Timer sender, EventArgs args)
			=> Console.WriteLine(DateTime.Now.TimeOfDay);
	}
}
