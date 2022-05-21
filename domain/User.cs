namespace Domain
{
    public class User
    {
        public string Username { get; } //only get makes it readonly 

        public User(string username)
        {
            Username = username;
        }
    }
}
