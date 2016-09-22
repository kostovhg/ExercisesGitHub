using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_NumbersToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string ones, teens, tens;
            ones = teens = tens = string.Empty;

            if (n > 10 && n < 20)
            {
                switch (n)
                {
                    case 11: teens += ("Eleven"); break;
                    case 12: teens += ("Twelve"); break;
                    case 13: teens += ("Thirteen"); break;
                    case 14: teens += ("Fourteen"); break;
                    case 15: teens += ("Fifteen"); break;
                    case 16: teens += ("Sixteen"); break;
                    case 17: teens += ("Seventeen"); break;
                    case 18: teens += ("Eighteen"); break;
                    case 19: teens += ("Nineteen"); break;
                    default: break;
                }
                Console.WriteLine(teens);
            }
            else if (n>19 || n<11)
            {
                switch (n / 10)
                {
                    //case 0: tens += ""; break;
                    case 2: tens += ("Twenty"); break;
                    case 3: tens += ("Thirty"); break;
                    case 4: tens += ("Forty"); break;
                    case 5: tens += ("Fifty"); break;
                    case 6: tens += ("Sixty"); break;
                    case 7: tens += ("Seventy"); break;
                    case 8: tens += ("Eighty"); break;
                    case 9: tens += ("Ninety"); break;
                    default: break;
                }
                switch (n % 10)
                {
                    case 1: ones += ("One"); break;
                    case 2: ones += ("Two"); break;
                    case 3: ones += ("Three"); break;
                    case 4: ones += ("Four"); break;
                    case 5: ones += ("Five"); break;
                    case 6: ones += ("Six"); break;
                    case 7: ones += ("Seven"); break;
                    case 8: ones += ("Eight"); break;
                    case 9: ones += ("Nine"); break;
                    case 0: ones += (n>10 ? "Thousand" : "Ten"); break;
                    default:
                        break;
                }

                if (n<11)
                    Console.WriteLine(ones);
                else if (n % 10 != 0)
                    Console.WriteLine(tens + "-" + ones.ToLower());
                else
                    Console.WriteLine(tens);
            }

        }
    }
}
