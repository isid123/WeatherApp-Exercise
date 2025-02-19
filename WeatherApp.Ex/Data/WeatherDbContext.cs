using Microsoft.EntityFrameworkCore;

namespace WeatherApp.Ex.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext() : base() { }

        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
