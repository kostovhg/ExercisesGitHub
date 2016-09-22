using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14_PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            
            // long variant
            int dLeft = 0; // down figure left border/ x min
            int dRight = h * 3; // down figure right border / x max
            int uLeft = h; // up figure left border / x min
            int uRight = h * 2; // up figure right border / x max 
            int dBottom = 0; // down figure bottom border / y min
            int dTop = h; // down figure top border / y max
            int uBottom = h; // up figure bottom border / y min
            int uTop = h * 4 ; // up figure top border / y max

            if ( 
                (x > dLeft && x < dRight && y > dBottom && y < dTop) ||
                (x > uLeft && x < uRight && y > uBottom && y < uTop) ||
                (y == uBottom && x > uLeft && x < uRight)
                ) Console.WriteLine("inside");
            else if (
                ((x == dLeft || x == dRight ) && y >= dBottom && y <= dTop) ||
                ((x == uLeft || x == uRight) && y >= uBottom && y <= uTop) ||
                ((y == dBottom) && x >= dLeft && x <= dRight) ||
                ((y == uTop) && x >= uLeft && x <= uRight) ||
                (y == uBottom) && ((x >= dLeft && x <= uLeft) || (x >= uRight && x <= dRight))
                ) Console.WriteLine("border");
            else Console.WriteLine("outside");

        }
    }
}
