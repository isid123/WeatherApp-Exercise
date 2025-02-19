using System.Globalization;
using WeatherApp.Ex.Data;

namespace WeatherApp.Ex.DTO
{
    public class CityDTO
    {
        public required string Name { get; set; }
        public required string Country { get; set; }
        public Weather? Weather { get; set; }

    }
}
