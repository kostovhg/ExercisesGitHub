using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05_NumberFrom0To9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read number (n) from user input
            int n = int.Parse(Console.ReadLine());

            // Declare variables for ones, tens, teens, hundreds and so on.
            string hudreds, teens, tens, ones;

            // Set string variables to "Empty"
            hudreds = teens = tens = ones = string.Empty;

            // Check the decimal notation and assigin different from Empty to string variables
            if (n >= 20) // main IF, in case of maximum number = 99
            {
                // set tens as reminder after devision by 10

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
            }
            else if (n >= 11 & n < 20)
            {
                switch (n)
                {
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
                    case 0: ones += ("Ten"); break;
                    default:
                        break;
                }
                Console.WriteLine("We are going to display tens, teens and ones.");
                Console.WriteLine("{1}" + ((n > 20 && n % 10 != 0) ? "-" : "") + "{0}", tens, ones);
                 }
    }
}
