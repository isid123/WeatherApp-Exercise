using Microsoft.EntityFrameworkCore;

namespace WeatherApp.Ex.Data
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext() : base() { }

        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }

    }
}
