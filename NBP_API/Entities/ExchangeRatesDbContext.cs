using Microsoft.EntityFrameworkCore;

namespace NBP_API.Entities
{
    public class ExchangeRatesDbContext : DbContext
    {
        private string _connectionString =
            "Server=localhost;Database=NBP_API_DB;Trusted_Connection=True;";
        public DbSet<ExchangeRates> ExchangeRates { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Rate2> Rates2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }  
}
