using System;

namespace ex08_TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var commisions = -1.0;

            if (quantity <= 500 && quantity >= 0)
            {
                if (town == "sofia") commisions = 0.05;
                if (town == "varna") commisions = 0.045;
                if (town == "plovdiv") commisions = 0.055;
            }
            else if (quantity <= 1000 && quantity > 500)
            {
                if (town == "sofia") commisions = 0.07;
                if (town == "varna") commisions = 0.075;
                if (town == "plovdiv") commisions = 0.08;
            }
            else if (quantity <= 10000 && quantity > 1000)
            {
                if (town == "sofia") commisions = 0.08;
                if (town == "varna") commisions = 0.1;
                if (town == "plovdiv") commisions = 0.12;
            }
            else if (quantity > 10000)
            {
                if (town == "sofia") commisions = 0.12;
                if (town == "varna") commisions = 0.13;
                if (town == "plovdiv") commisions = 0.145;
            }

            if (commisions > 0) Console.WriteLine("{0:F2}", quantity * commisions);
            else Console.WriteLine("error");
        }
    }
}
