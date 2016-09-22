using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_To_Centimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var numIn = double.Parse(Console.ReadLine());
            Console.WriteLine("centimeters = " + numIn * 2.54);
        }
    }
}
