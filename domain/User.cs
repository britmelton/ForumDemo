namespace Domain
{
    public class User
    {
        public string Username { get; } //only get makes it readonly 
        public Guid Id { get; }

        public User(string username)
        {
            Username = username;
            Id = Guid.NewGuid();
        }
    }
}
