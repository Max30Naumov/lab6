using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public interface IWeatherApp
    {
         void GetWeather(string location);
         void SetUnits(string units);
         string ToString();

    }
}
