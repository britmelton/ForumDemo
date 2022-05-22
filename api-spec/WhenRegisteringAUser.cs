using api.Contracts;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace Api.Spec
{//only testing api
    [Collection("storage")]
    public class WhenRegisteringAUser : WebApiFixture
    {
        public WhenRegisteringAUser(IntegrationTestingFactory<Program> factory) 
            : base(factory, "users")
        {
        }

        [Fact]
        public async void ThenUserIsRegistered()
        {
            //call Api route with parameters
            var dto = new RegisterUserDto("johndoe", "1234", new DateTime(1990, 10, 1));
            var result = await HttpClient.PostAsJsonAsync("", dto);

            //call finduser api route and confirm the user we got exists 
            var user = await HttpClient.GetFromJsonAsync(result.Headers.Location, typeof(UserDto));
            user.Should().NotBeNull();
        }
    }
}
