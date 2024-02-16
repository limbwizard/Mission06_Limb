using Microsoft.EntityFrameworkCore;

namespace Mission06_Limb.Models
{
    public class MovieEntryContext : DbContext
    {
        public MovieEntryContext(DbContextOptions<MovieEntryContext> options) : base (options)
        {
        }

        public DbSet<Entry> Entries { get; set; }
    }
}
