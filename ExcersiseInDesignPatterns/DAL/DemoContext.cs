using Microsoft.EntityFrameworkCore;

namespace ExcersiseInDesignPatterns.DAL
{
    public class DemoContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DemoContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
