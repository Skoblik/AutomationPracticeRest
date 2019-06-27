using Newtonsoft.Json;

namespace GoRest.Models
{
	public class Edit
	{
		[JsonProperty("href")]
		public string Href { get; set; }
	}
}