namespace infrastructure
{
    public class User : Entity
    {
        public User()
        {
        }

        public User(Domain.User user) : base(user.Id)
        {
            Username = user.Username;
            Password = user.Password;
            Birthday = user.Birthday;
        }

        public string Username { get; set; }    
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
    }
}
