using Microsoft.EntityFrameworkCore;

namespace Ders22_Uygulama.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=Ders23; Integrated Security=SSPI;";

            builder.UseSqlServer(connectionString);
        }
    }
}
