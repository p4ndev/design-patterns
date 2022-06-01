namespace EncryptExample{
	class MainClass	{
		public static void Main (string[] args){

			FileWriter fw = new DESWriter("encrypted.txt");
			fw.Append("The quick brown fox jumped over the lazy dog.");

			fw = new UnencryptedWriter("unencrypted.txt");
			fw.Append("The quick brown fox jumped over the lazy dog.");

		}
	}
}
