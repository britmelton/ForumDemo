namespace Domain
{
    public class User
    {
        public string Username { get; } //only get makes it readonly 
        public Guid Id { get; }
        public string Password { get; }
        public DateTime Birthday { get; }

        public User(string username, string password, DateTime birthday, Guid id = default)
        {
            Username = username;        
            Password = password;
            Birthday = birthday;
            Id = id == default ? Guid.NewGuid() : id;
        }
    }
}
