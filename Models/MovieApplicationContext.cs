using Microsoft.EntityFrameworkCore;

namespace Mission06_Imerlishvili.Models
{
    public class MovieApplicationContext:DbContext
    {
        public MovieApplicationContext(DbContextOptions <MovieApplicationContext> options) : base (options)
        {

        }
        public DbSet<Application> Applications { get; set; }
    }
}
