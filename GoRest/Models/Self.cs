using Newtonsoft.Json;

namespace GoRest.Models
{
	public class Self
	{
		[JsonProperty("href")]
		public string Href { get; set; }
	}
}