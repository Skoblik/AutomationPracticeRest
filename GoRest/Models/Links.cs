using Newtonsoft.Json;

namespace GoRest.Models
{
	public class Links
	{
		[JsonProperty("self")]
		public Self Self { get; set; }

		[JsonProperty("edit")]
		public Edit Edit { get; set; }

		[JsonProperty("avatar")]
		public Avatar Avatar { get; set; }
	}
}