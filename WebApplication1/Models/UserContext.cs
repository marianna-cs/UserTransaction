


using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        private const string DECIMAL_PRECISION = "decimal(18,8)";
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Transaction>().Property(t => t.Amount).HasColumnType(DECIMAL_PRECISION);
        }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
 
    }

}
