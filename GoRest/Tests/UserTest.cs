using GoRest.Clients;
using GoRest.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace GoRest.Tests
{
	[TestFixture()]
	public class UserTest
	{
		[Test]
		public void CreateUserTest()
		{
			var client = new UserApiClient();

			var user = new User
			{
				FirstName = "Onotole",
				LastName = "Vassermann",
				Gender = "male",
				Email = "onotole@email.com",
				Status = "active"
			};

			var createdUser = client.CreateUser(user);

			Assert.That(createdUser.Id, Is.Not.Null);
		}

		[Test]
		public void Serialization()
		{
			var user = new User
			{
				FirstName = "Onotole",
				LastName = "Vassermann",
				Gender = "male",
				Email = "onotole@email.com",
				Status = "active"
			};

			var json = JsonConvert.SerializeObject(user, Formatting.None,
				
				new JsonSerializerSettings()
				{
					NullValueHandling = NullValueHandling.Ignore
				}
				);
			User obj = JsonConvert.DeserializeObject<User>(json);
		}
	}
}