using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Ex.Data;
using WeatherApp.Ex.DTO;

namespace WeatherApp.Ex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly WeatherDbContext ctx;
        private readonly Mapper mapper;

        public UserController(WeatherDbContext ctx, Mapper mapper)
        {
            this.ctx = ctx;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = ctx.Users.ToList().ConvertAll(mapper.MapEntityToDto);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(UserDTO user)
        {
            var entity = mapper.MapDtoToEntity(user);
            ctx.Users.Add(entity);
            ctx.SaveChanges();
            return Ok();
        }
    }
}
