namespace Domain
{
    public class User
    {
        public string Username { get; } //only get makes it readonly 
        public Guid Id { get; }
        public string Password { get; }

        public User(string username, string password)
        {
            Username = username;
            Id = Guid.NewGuid();
            Password = password;
        }
    }
}
