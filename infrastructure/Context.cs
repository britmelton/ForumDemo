using Microsoft.EntityFrameworkCore;

namespace infrastructure
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }  
    }
}
