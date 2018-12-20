using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Converter
    {
        public Double FahrenheitToCelsius(Double temp)
        {
            return (temp - 32) / 1.8 ;
        }

        public Double FahrenheitToKelvin(Double temp)
        {
            return FahrenheitToCelsius(temp) + 273.15;
        }

        public Double CelsiusToFahrenheit(Double temp)
        {
            return (1.8 * temp) + 32;
        }

        public Double CelsiusToKelvin(Double temp)
        {
            return temp + 273.15;
        }

        public Double KelvinToFahrenheit(Double temp)
        {
            return CelsiusToFahrenheit(temp - 273.15);
        }

        public Double KelvinToCelsius(Double temp)
        {
            return temp - 273.15;
        }
    }
}
