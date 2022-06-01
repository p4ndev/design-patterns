using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Net;

namespace BitcoinExample {

	class BitcoinApi : Coin {

		public override decimal GetValueInUSD() {			
			var request = WebRequest.Create(@"http://coinabul.com/api.php");

			using (var response = request.GetResponse() as HttpWebResponse) {
				var ser = new DataContractJsonSerializer(typeof(BitcoinResponse));
				var obj = ser.ReadObject(response.GetResponseStream());
				BitcoinResponse json = obj as BitcoinResponse;
				if (json != null) return (decimal)json.BTC.USD;
			}

			return 0;
		}
	}

	[DataContract]
	public class BitcoinResponse{
		[DataMember(Name = "BTC")]
		public BTCResponse BTC { get; set; }
	}

	[DataContract]
	public class BTCResponse{
		[DataMember(Name = "USD")]
		public float USD { get; set; }
	}

}
