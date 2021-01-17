using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkalonZeus.Models
{
    public class CurrentWeatherViewModel
    {
        public string PlaceName { get; set; }
        public string CurrentTime{ get; set; }
        public int TemperatureCelcius { get; set; }
        public string IconUri { get; set; }
        public string Description { get; set; }
        public int FeelsLikeCelsius { get; set; }
        public string Humidity { get; set; }
        public string Pressure { get; set; }
        public string Visibility { get; set; }
        public int WindDeg { get; set; }
        public string WindSpeed { get; set; }
        public int DewPointCelsius { get; set; }
        public string Uvi { get; set; }
    }
}
