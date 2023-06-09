﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Repository
{
    public interface IWeatherRepository
    {
        Task<Weather> GetWeather(string name);
    }
}
