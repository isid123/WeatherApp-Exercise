namespace WeatherApp.Ex.Data
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public List<City>? FavoriteCities { get; set; } = new List<City>()
        {
            new City { Name = "New York", Country = "USA" },
            new City { Name = "London", Country = "UK" },
            new City { Name = "Paris", Country = "France" }
        };
    }
}
