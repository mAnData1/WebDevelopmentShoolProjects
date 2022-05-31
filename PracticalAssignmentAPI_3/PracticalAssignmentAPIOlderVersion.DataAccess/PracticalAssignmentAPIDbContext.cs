using Microsoft.EntityFrameworkCore;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;

namespace PracticalAssignmentAPIOlderVersion.DataAccess
{
    public class PracticalAssignmentAPIDbContext : DbContext
    {
        public PracticalAssignmentAPIDbContext(DbContextOptions<PracticalAssignmentAPIDbContext> options)
            : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .HasForeignKey(c => c.BrandId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
