using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithCoordinates
{
    class RectangleWithCoordinates
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var area = Math.Abs((y2-y1)*(x2-x1));
            var perimeter =2*( Math.Abs(y2 - y1) + Math.Abs(x2 - x1));
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
