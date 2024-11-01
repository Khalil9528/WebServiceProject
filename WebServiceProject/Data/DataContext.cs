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
            // Movie - Review (One-to-Many)
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Reviews)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Cascade);  // Cascade delete for reviews when a movie is deleted

            // User - Review (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.Reviewer)
                .HasForeignKey(r => r.ReviewerId);

            // Movie - Genre (Many-to-Many)
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Genres)
                .WithMany(g => g.Movies)
                .UsingEntity(j => j.ToTable("MovieGenres"));  // Customize the join table name

            // Index on Movie title
            modelBuilder.Entity<Movie>()
                .HasIndex(m => m.Title)
                .IsUnique();  // Enforce unique titles for movies

            base.OnModelCreating(modelBuilder);
        }
    }
}
