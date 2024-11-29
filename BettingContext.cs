using BettingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Database
{
    public class BettingContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Match> Matches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;" +                     // Server name
                "port=3306;" +                            // Server port
                "user=c_sharp_dev;" +                     // Username
                "password=Larshop;" +                 // Password
                "database=Matches;"       // Database name
                , Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.21-mysql") // Version
                );
        }
    }
}
