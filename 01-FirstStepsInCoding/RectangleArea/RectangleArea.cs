using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            try
            {
                var a = decimal.Parse(Console.ReadLine());
                var b = decimal.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
