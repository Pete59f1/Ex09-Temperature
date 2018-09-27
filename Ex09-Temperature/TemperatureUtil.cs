using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    public class TemperatureUtil
    {
        public static double FahrenheitToCelsius(double v)
        {
            return  (v - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double v)
        {
            return (9 * v) / 5 + 32;
        }
    }
}
