using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            // USD/BGN = 1.79549; EUR/BGN = 1.95583; GBP/BGN = 2.53405 
            // or USD=x*BGN, EUR=y*BGN, GBP = z*BGN
            double x = 1.79549;
            double y = 1.95583;
            double z = 2.53405;

            double[, ] course = { { 1, 1/x, 1/y, 1/z }, { x , 1, x/y, x/z },
                {y , y/x, 1 ,y/z }, {z, z/x, z/y, 1}};

            double amount = double.Parse(Console.ReadLine());
            string currFrom = Console.ReadLine();
            string currTo = Console.ReadLine();
            int j;
            int i;

            switch (currFrom)
            {
                case "USD": i=1; break; case "EUR": i=2; break; case "GBP": i=3; break; default: i=0; break;
            }
            switch (currTo)
            {
                case "USD": j = 1; break; case "EUR": j = 2; break; case "GBP": j = 3; break;
                default: j = 0; break;
            }

            Console.WriteLine(Math.Round(amount * course[i, j], 2)+ " " + currTo);
        }
    }
}
