using Microsoft.EntityFrameworkCore;
using RestaurantReviewApp.Models;

namespace RestaurantReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        { 

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Location> Locations { get; set; }  

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Restaurant> Restaurants { get; set; }  

        public DbSet<RestaurantCategory> RestaurantCategories { get; set;  }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Reviewer> Reviewers { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantCategory>()
                .HasKey(rc => new { rc.RestaurantId, rc.CategoryId });
            modelBuilder.Entity<RestaurantCategory>()
                .HasOne(r => r.Restaurant)
                .WithMany(rc => rc.RestaurantCategories)
                .HasForeignKey(r => r.RestaurantId);
            modelBuilder.Entity<RestaurantCategory>()
                .HasOne(r => r.Category)
                .WithMany(rc => rc.RestaurantCategories)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
