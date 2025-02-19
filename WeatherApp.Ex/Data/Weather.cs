
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace WeatherApp.Ex.Data
{

    public class Weather
    {
        private static readonly Random random = new Random();
        public int Temperature { get; set; } = random.Next(-15, 32);
        public int Humidity { get; set; } = random.Next(0, 100);

    }
}
