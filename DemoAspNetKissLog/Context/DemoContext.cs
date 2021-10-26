using DemoAspNetKissLog.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoAspNetKissLog.Context
{
    public class DemoContext : DbContext
    {        
        public DemoContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DemoContext).Assembly);
        }
    }
}