using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower();
            var hollidays = int.Parse(Console.ReadLine());
            var homeTownWeekends = int.Parse(Console.ReadLine());
            double playing;

            playing = (48 - homeTownWeekends) * (3d/4); // play days in Sofia
            playing += homeTownWeekends + (2d / 3) * hollidays; // play days in HomeTown
            Console.WriteLine(Math.Truncate((yearType == "leap") ? (playing * 1.15) : playing));


        }
    }
}
