namespace EncryptExample{
	class UnencryptedWriter : FileWriter{
		
		public UnencryptedWriter(string path) => _path = path;

		protected override void DecryptFile() { }

		protected override void EncryptFile() { }
		
	}
}
