using RestSharp;

namespace GoRest.Clients
{
	public class BaseApiClient
	{
		private readonly RestClient _client;

		public BaseApiClient()
		{
			_client = new RestClient(Settings.Url);
			_client.FollowRedirects = false;
		}

		protected IRestResponse SendRequest(IRestRequest request)
		{
			return _client.Execute(request);
		}
	}
}