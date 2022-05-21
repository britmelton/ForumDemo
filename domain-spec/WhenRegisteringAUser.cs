using FluentAssertions;

namespace Domain.Spec
{
    public class WhenRegisteringAUser
    {
        [Fact]
        public void ThenUsernameIsSet()
        {
            var user = new User("johndoe");
            user.Username.Should().Be("johndoe");
        }
    }
}
