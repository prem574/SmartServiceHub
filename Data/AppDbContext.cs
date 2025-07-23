using Microsoft.EntityFrameworkCore;
using SmartServiceHub.Model;

namespace SmartServiceHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Default values
            modelBuilder.Entity<ServiceRequest>()
                .Property(sr => sr.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ServiceRequest>()
                .Property(sr => sr.Status)
                .HasDefaultValue("Pending");
        }
    }
}