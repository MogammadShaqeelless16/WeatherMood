using Microsoft.EntityFrameworkCore;
using WeatherMood.Models; // Make sure this matches your namespace

namespace WeatherMood.Data
{
    public class AppDbContext : DbContext
    {
        // Required constructor for DI
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MoodRecord> Moods => Set<MoodRecord>();

        // Remove any OnConfiguring method if present
    }
}