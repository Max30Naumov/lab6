using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public abstract class WeatherApp : IWeatherApp
    {
        private readonly string defaultLocation;
        public string DefaultLocation { get => defaultLocation; init => defaultLocation = value ; }
        public WeatherApp() 
        {
           DefaultLocation = "Одесса";
        }
        public abstract void GetWeather(string location);

        public abstract void SetUnits(string units);

        public abstract string ToString();
    }
}
