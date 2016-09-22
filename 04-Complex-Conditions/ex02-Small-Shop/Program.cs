using System;

namespace ex02_Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] prices = new double[3, 5] { { 0.50, 0.80, 1.20, 1.45, 1.60 },
            {0.4, 0.70, 1.15, 1.30, 1.50}, { 0.45, 0.70, 1.10, 1.35, 1.55} };

            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            int i = 0;
            int j = 0;

            switch (product)
            {
                case "coffee": i = 0; break;
                case "water": i = 1; break;
                case "beer": i = 2; break;
                case "sweets": i = 3; break;
                case "peanuts": i = 4; break;
                default:
                    break;
            }

            switch (city)
            {
                case "sofia": j = 0; break;
                case "plovdiv": j = 1; break;
                case "varna": j = 2; break;
                default:
                    break;
            }

            Console.WriteLine("{0}", prices[j,i]*quantity);
        }
    }
}
