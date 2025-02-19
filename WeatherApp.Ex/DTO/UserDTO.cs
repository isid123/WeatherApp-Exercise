using WeatherApp.Ex.Data;

namespace WeatherApp.Ex.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public List<FavoriteCities>? FavoriteCities { get; set; }
    }
}
