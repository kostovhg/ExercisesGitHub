using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class TrangleOf55Stars
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                string stars = new string('*', i);
                Console.WriteLine(stars);
            }
        }
    }
}
