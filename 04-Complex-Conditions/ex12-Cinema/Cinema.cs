using System;

namespace ex12_Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var price = -1.0;

            switch (type)
            {
                case "premiere":  price = 12.00; break;
                case "normal": price = 7.5; break;
                case "discount": price = 5; break;
                default:
                    break;
            }

            Console.WriteLine("{0:f2} leva", (r * c) * price);

        }
    }
}
