using Newtonsoft.Json;

namespace GoRest.Models
{
	public class UserResponse
	{
		[JsonProperty("_meta")]
		public Meta Meta { get; set; }

		[JsonProperty("result")]
		public User User { get; set; }
	}
}