using WeatherApp.Ex.Data;

namespace WeatherApp.Ex.DTO
{
    public class Mapper
    {

        /* API
         * User : email e nome
         * City
         * Weather : temperatura umidità Data
         * Città favorite utente **
         * ritornare citta favorite + condizioni meteo di esse nei prossimi 3 giorni
         */
        public UserDTO MapEntityToDto(User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                FavoriteCities = user.FavoriteCities,
            };
        }
        public User MapDtoToEntity(UserDTO userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Name = userDto.Name,
                Email = userDto.Email,
            };
        }
        
        public CityDTO MapEntityToDto(City city)
        {
            return new CityDTO
            {
                Name = city.Name,
                Country = city.Country,
                Weather = city.Weather,
            };
        }
        public City MapDtoToEntity(CityDTO cityDto)
        {
            return new City
            {
                Name = cityDto.Name,
                Country = cityDto.Country,
                Weather = cityDto.Weather,
            };
        }
    }
}
