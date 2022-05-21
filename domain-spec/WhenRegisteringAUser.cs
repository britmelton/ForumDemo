using FluentAssertions;

namespace Domain.Spec
{
    public class WhenRegisteringAUser
    {
        private readonly User _user;
        public WhenRegisteringAUser()
        {
             _user = new User("johndoe", "1234");
        }

        [Fact]
        public void ThenUsernameIsSet()
        {
            _user.Username.Should().Be("johndoe");
        }

        [Fact]
        public void ThenIdIsSet()
        {
            _user.Id.Should().NotBeEmpty();
        }

        [Fact]
        public void ThenPasswordIsSet()
        {
            _user.Password.Should().Be("1234");
        }
    }
}
