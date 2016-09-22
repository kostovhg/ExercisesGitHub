using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Number09ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string hundreds = "";
            string tens = "";
            string ones = "";
                switch (num / 10)
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
                    case 10: tens += ("One hundred"); break;
                    default: break;
                }

            switch (num % 10)
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
                case 10: ones += ("Ten"); break;
                case 11: ones += ("Eleven"); break;
                case 12: ones += ("Twelve"); break;
                case 13: ones += ("Thirteen"); break;
                case 14: ones += ("Fourteen"); break;
                case 15: ones += ("Fifteen"); break;
                case 16: ones += ("Sixteen"); break;
                case 17: ones += ("Seventeen"); break;
                case 18: ones += ("Eighteen"); break;
                case 19: ones += ("Nineteen"); break;
                default: break;
            }
            if (num > 19)
            {
                Console.WriteLine(tens + (num%10 == 0 ? "": "-") + ones.ToLower());
            }
            else
            {
                Console.WriteLine(ones);
            }
            
        }
    }
}
