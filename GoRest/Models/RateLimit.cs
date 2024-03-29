﻿using Newtonsoft.Json;

namespace GoRest.Models
{
	public class RateLimit
	{
		[JsonProperty("limit")]
		public int Limit { get; set; }

		[JsonProperty("remaining")]
		public int Remaining { get; set; }

		[JsonProperty("reset")]
		public int Reset { get; set; }
	}
}