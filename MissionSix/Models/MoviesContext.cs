using Microsoft.EntityFrameworkCore;

namespace MissionSix.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new  Categories { CategoryId=1,CategoryName="Sci-fi"}
 
                );
        }
    }
}
