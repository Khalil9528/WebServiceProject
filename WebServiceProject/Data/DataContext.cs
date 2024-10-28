using Microsoft.EntityFrameworkCore;
using WebServiceProject.Models;

namespace WebServiceProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Reviews)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.Reviewer)
                .HasForeignKey(r => r.ReviewerId);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Movies)
                .WithMany(m => m.Genres);

            base.OnModelCreating(modelBuilder);
        }



    }
}
