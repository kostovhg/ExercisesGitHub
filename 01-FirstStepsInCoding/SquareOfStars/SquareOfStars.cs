using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n >= 2 & n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j<= n; j++)
                    {
                        if (j == 1 || i == 1 || j == n || i == n)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You didn't entered number between 2 and 100");
            }
        }
    }
}
