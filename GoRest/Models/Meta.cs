using Newtonsoft.Json;

namespace GoRest.Models
{
	public class Meta
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("rateLimit")]
		public RateLimit RateLimit { get; set; }
	}
}