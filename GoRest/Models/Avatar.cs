using Newtonsoft.Json;

namespace GoRest.Models
{
	public class Avatar
	{
		[JsonProperty("href")]
		public object Href { get; set; }
	}
}