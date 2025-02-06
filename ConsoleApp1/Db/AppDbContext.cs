using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Db
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cocktail> Cocktails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MTorres-LAP\\SQLEXPRESS;Database=ConsoleApp1;User Id=sa;Password=123456;TrustServerCertificate=True;");
        }
    }
}
