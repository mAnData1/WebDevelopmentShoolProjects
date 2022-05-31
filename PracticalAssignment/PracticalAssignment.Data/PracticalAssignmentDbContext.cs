using Microsoft.EntityFrameworkCore;
using PracticalAssignment.Data.Entities;

namespace PracticalAssignment.Data
{
    public class PracticalAssignmentDbContext : DbContext
    {
        public PracticalAssignmentDbContext(DbContextOptions<PracticalAssignmentDbContext> options)
            : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
