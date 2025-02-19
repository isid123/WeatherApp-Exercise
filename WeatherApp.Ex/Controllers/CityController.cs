using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Ex.Data;
using WeatherApp.Ex.DTO;

namespace WeatherApp.Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly WeatherDbContext ctx;
        private readonly Mapper mapper;
        public CityController(WeatherDbContext ctx, Mapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }
    }
}
