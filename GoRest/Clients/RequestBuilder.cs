using Newtonsoft.Json;
using RestSharp;

namespace GoRest.Clients
{
	public class RequestBuilder
	{
		public static RestRequest PostRequest(string resource, object payload = null)
		{
			var request = new RestRequest();
			request.AddHeader("Authorization", $"Bearer {Settings.AccessToken}");
			request.AddHeader("Accept", "application/json");
			request.AddHeader("Content-Type", "application/json");

			request.Method = Method.POST;
			request.Resource = resource;

			if (payload != null)
			{
				string body = JsonConvert.SerializeObject(payload);
				request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
				request.RequestFormat = DataFormat.Json;
			}

			return request;
		}
	}
}