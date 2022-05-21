using FluentAssertions;

namespace Domain.Spec
{
    public class WhenRegisteringAUser
    {
        private readonly User _user;
        private readonly string _username = "johndoe";
        private readonly string _password = "1234";
        private readonly DateTime _birthday = new DateTime(1990, 10, 1);

        public WhenRegisteringAUser()
        {
             _user = new User(_username, _password, _birthday);

        }

        [Fact]
        public void ThenUsernameIsSet()
        {
            _user.Username.Should().Be(_username);
        }

        [Fact]
        public void ThenIdIsSet()
        {
            _user.Id.Should().NotBeEmpty();
        }

        [Fact]
        public void ThenPasswordIsSet()
        {
            _user.Password.Should().Be(_password);
        }

        [Fact]
        public void ThenBirthdayIsSet()
        {
            _user.Birthday.Should().Be(_birthday);
        }
    }
}
