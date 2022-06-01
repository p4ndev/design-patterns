namespace SingletonPattern{

    public class Logger{

		private Stream?			_logStream		= null;
		private StreamWriter?	_streamWriter	= null;

		public Logger(){
			_logStream		= File.Open("logfile.log", FileMode.OpenOrCreate);
			_streamWriter	= new StreamWriter(_logStream);
		}

		public void Log(string message) {
			if (_streamWriter != null)
				_streamWriter.WriteLine(message);
		}

		private void StreamWriterDone() {
			if (_streamWriter == null) return;
			_streamWriter.Flush();
			_streamWriter.Close();
			_streamWriter.Dispose();
		}

		private void StreamDone() {
			if (_logStream == null) return;
			_logStream.Close();
			_logStream.Dispose();
		}

		public void Done(){
			StreamWriterDone();
			StreamDone();
		}

	}

	public sealed class Singleton{

		private static object _semaphore = new object();
		private static Logger? _instance = null;
		
		public static Logger Instance {
			get {
				lock (_semaphore) {
					if (_instance == null)
						_instance = new Logger();
				}
				return _instance!;
			}
		}

	}

}
