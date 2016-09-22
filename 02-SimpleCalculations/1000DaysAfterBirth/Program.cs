using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cul = CultureInfo.CurrentCulture;
            string s = Console.ReadLine();

            var inDate = DateTime.ParseExact(s, "dd-MM-yyyy", cul);
            var outDate = inDate.AddDays(999);
            Console.WriteLine("{0:dd-MM-yyy}", outDate);
        }
    }
}
