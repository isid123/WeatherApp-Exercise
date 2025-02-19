using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApp.Ex.Data
{
    [PrimaryKey(nameof(CityId), nameof(UserId))]
    public class FavoriteCities
    {
        public int UserId { get; set; }
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City? city { get; set; }
        [ForeignKey(nameof(UserId))]
        public User? user { get; set; }
    }
}
