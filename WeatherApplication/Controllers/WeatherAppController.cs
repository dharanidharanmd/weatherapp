using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherAppController : ControllerBase
    {
        public readonly IWeatherService _weatherService;

        public WeatherAppController(IWeatherService weatherservice)
        {
            _weatherService = weatherservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeather(string name)
        {
            try
            {
                Weather weather = await _weatherService.GetWeather(name);
                if(weather!=null)
                {
                    return Ok(weather);
                }
                else
                {
                    return NotFound();
                }
            }
            catch ( Exception ex) 
            {
                throw;
            }
        }

    }
}
