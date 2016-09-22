using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tmp03
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegitablesPrice = decimal.Parse(Console.ReadLine());
            decimal fruitPrice = decimal.Parse(Console.ReadLine());
            var vegKg = int.Parse(Console.ReadLine());
            var fruitKg = int.Parse(Console.ReadLine());

            decimal vegIncome = vegitablesPrice * vegKg;
            decimal fruitIncome = fruitPrice * fruitKg;

            decimal totalIncomeBGN = vegIncome + fruitIncome;

            decimal totalIncomeEuro = totalIncomeBGN / 1.94m;
            Console.WriteLine(totalIncomeEuro);
        }
    }
}
