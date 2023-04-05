
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Weather
    {
        public int id { get; set; }
        public string name { get; set; }
        public Main main { get; set; }
        public string description { get; set; }
    }

    public class Main 
    {
        public double temperature { get; set; }
        public double feels_like { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
    }

}
