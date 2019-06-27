using Newtonsoft.Json;

namespace GoRest.Models
{
	public class User
	{
		[JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("dob")]
        public object Dob { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("website")]
        public object Website { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
	}
}