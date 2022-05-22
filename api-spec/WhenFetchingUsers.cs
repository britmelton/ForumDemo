using api.Contracts;
using FluentAssertions;
using System.Net.Http.Json;

namespace Api.Spec
{//only testing api
    [Collection("storage")]
    public class WhenFetchingUsers : WebApiFixture
    {
        public WhenFetchingUsers(IntegrationTestingFactory<Program> factory)
            : base(factory, "users")
        {
        }

        [Fact]
        public async void ThenUsersAreReturned()
        {
            var jeff = new RegisterUserDto("jeffdoe", "1234", new DateTime(2013, 06, 13));
            await HttpClient.PostAsJsonAsync("", jeff);
            var jane = new RegisterUserDto("janedoe", "5678", new DateTime(1993, 03, 13));
            await HttpClient.PostAsJsonAsync("", jane);

            var result = await HttpClient.GetFromJsonAsync<IEnumerable<UserDto>>("");

            result.Should().Contain(new UserDto("jeffdoe", new DateTime(2013, 06, 13)));
            result.Should().Contain(new UserDto("janedoe", new DateTime(1993, 03, 13)));

        }
    }
}
