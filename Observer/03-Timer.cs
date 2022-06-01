using System.Threading;
using System;

namespace TimerExample{
	public class Timer{

		private Thread _thread;
		
		public event NotifyEvent<Timer> Notify;
		
		private void Emit()		=> Notify(this, new EventArgs());
		private void Delay()	=> Thread.Sleep(1000);
		private void Call()		=> _thread.Start();

		public void Start(){

			_thread = new Thread(() => {
				while (true){
					if (Notify != null) Emit();
					Delay();
				}
			});

			Call();

		}

	}
}
