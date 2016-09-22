using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            var cel = double.Parse(Console.ReadLine());
            var fah = cel * 1.8 + 32;
            Console.WriteLine(Math.Round(fah, 2));
        }
    }
}
