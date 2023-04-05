using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Repository;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {

        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<Weather> GetWeather(string name)
        {
            return await _weatherRepository.GetWeather(name);
        }
    }
}
