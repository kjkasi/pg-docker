using Microsoft.EntityFrameworkCore;

namespace pg_docker
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=pg;Port=5432;Database=test;Username=postgres;Password=Qwerty1");
        }
    }
}
