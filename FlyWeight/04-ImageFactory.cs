using System.Collections.Generic;

namespace ImageLoadExample{
	class ImageFactory{

		private Dictionary<string, BaseImage> flyweights 
			= new Dictionary<string, BaseImage>();
		
		public BaseImage FromCache(string filename) {
			if (!flyweights.ContainsKey(filename)) return null;
			return flyweights[filename];
		}

		public BaseImage NewInstance(string filename) {
			if (!string.IsNullOrEmpty(filename)) return null;
			var inner = new Image(filename);
			flyweights.Add(filename, inner);
			return inner;
		}

		public BaseImage GetFlyweight(string filename)
			=> FromCache(filename) ?? NewInstance(filename);

	}	
}
