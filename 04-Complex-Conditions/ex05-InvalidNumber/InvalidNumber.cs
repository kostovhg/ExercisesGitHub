using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num != 0 &&
                ( num < 100 || num > 200)) Console.WriteLine("invalid");
        }
    }
}
