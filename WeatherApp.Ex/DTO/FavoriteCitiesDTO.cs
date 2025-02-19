using System.ComponentModel.DataAnnotations.Schema;
using WeatherApp.Ex.Data;

namespace WeatherApp.Ex.DTO
{
    public class FavoriteCitiesDTO
    {
        public int UserId { get; set; }
        public int CityId { get; set; }
        public City? city { get; set; }
        public User? user { get; set; }
    }
}
