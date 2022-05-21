namespace infrastructure
{
    public class User : Entity
    {
        public string Username { get; set; }    
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
    }
}
