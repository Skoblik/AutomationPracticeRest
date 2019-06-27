using GoRest.Models;
using Newtonsoft.Json;

namespace GoRest.Clients
{
	public class UserApiClient : BaseApiClient
	{
		public User CreateUser(User user)
		{
			var request = RequestBuilder.PostRequest("/public-api/users", user);
			var response = SendRequest(request);
			var result = JsonConvert.DeserializeObject<UserResponse>(response.Content);
			return result.User;
		}
	}
}