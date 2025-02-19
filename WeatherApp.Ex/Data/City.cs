using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WeatherApp.Ex.Data
{
    [PrimaryKey(nameof(Id))]
    public class City
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
        [NotMapped]
        public string FormattedDate => DateTime.Today.ToString("dd/MM/yy", CultureInfo.InvariantCulture);

        [NotMapped]
        public Dictionary<string, Weather> Forecast { get; set; } = new Dictionary<string, Weather>
        {
            {"day1: " + DateTime.Today.ToString("dd/MM/yy", CultureInfo.InvariantCulture), new Weather() },
            {"day2: " + DateTime.Today.AddDays(1).ToString("dd/MM/yy", CultureInfo.InvariantCulture), new Weather() },
            {"day3: " + DateTime.Today.AddDays(2).ToString("dd/MM/yy", CultureInfo.InvariantCulture), new Weather() }
        };

        [NotMapped]
        public Weather? Weather { get; set; } = new Weather();
    }
}
