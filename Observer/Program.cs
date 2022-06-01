namespace TimerExample {
	class MainClass {
		public static void Main (string[] args){
			
			var timer = new Timer();
			var clock = new ConsoleClock();

			timer.Notify += clock.Update;

			timer.Start();

		}
	}
}
