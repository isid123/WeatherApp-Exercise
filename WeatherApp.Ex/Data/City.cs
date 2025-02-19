namespace WeatherApp.Ex.Data
{
    public class City
    {
        public required string Name { get; set; }
        public required string Country { get; set; }

        public List<FavoriteCities>? FavoriteCities { get; set; }
    }
}
