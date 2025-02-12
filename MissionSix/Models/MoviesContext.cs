using Microsoft.EntityFrameworkCore;

namespace MissionSix.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) 
        { 
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
