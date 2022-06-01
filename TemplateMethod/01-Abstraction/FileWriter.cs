using System.IO;

namespace EncryptExample{
	public abstract class FileWriter {

		protected string _path = null;

		protected abstract void DecryptFile();

		protected abstract void EncryptFile();

		protected virtual void AppendFile(string data){
			using (FileStream fs = File.Open (_path, FileMode.Append)){
				using (TextWriter tw = new StreamWriter(fs)){
					tw.Write (data);
				}
			}
		}

		// Template Method (entrypoint)
		public void Append(string data){
			DecryptFile();
			AppendFile(data);
			EncryptFile();
		}

	}
	
}
