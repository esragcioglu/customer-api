global using Microsoft.EntityFrameworkCore;

namespace customer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring (optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=customerdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
