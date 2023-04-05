using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Repository
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly HttpClient _client;
        public WeatherRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<Weather> GetWeather(string name)
        {
            var response = await _client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?appid=86b766cbd011374f0741913eba9a425c&q="+name);
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                var openWeather = JsonConvert.DeserializeObject<Weather>(content);
                openWeather.main.temp = (openWeather.main.temp - 32) * 0.55;
                return openWeather;
            }
            catch (Exception ex) 
            { 
                return null; 
            }
        }
    }
}
