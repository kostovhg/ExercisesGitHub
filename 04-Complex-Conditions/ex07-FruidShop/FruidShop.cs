using System;

namespace ex07_FruidShop
{
    class FruidSHop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            float price = -1f;

            if (day == "monday" || 
                day == "tuesday" || 
                day == "wednesday" ||
                day == "thursday" ||
                day == "friday" )
            {
                if (fruit == "banana") price = 2.5f;
                else if (fruit == "apple") price = 1.2f;
                else if (fruit == "orange") price = 0.85f;
                else if (fruit == "grapefruit") price = 1.45f;
                else if (fruit == "kiwi") price = 2.7f;
                else if (fruit == "pineapple") price = 5.5f;
                else if (fruit == "grapes") price = 3.85f;
            }
            else if (day == "saturday" ||
                day == "sunday")
            {
                if (fruit == "banana") price = 2.7f;
                else if (fruit == "apple") price = 1.25f;
                else if (fruit == "orange") price = 0.9f;
                else if (fruit == "grapefruit") price = 1.6f;
                else if (fruit == "kiwi") price = 3f;
                else if (fruit == "pineapple") price = 5.6f;
                else if (fruit == "grapes") price = 4.2f;
            }

            if (price >= 0) Console.WriteLine("{0:F2}", price * quantity);
            else Console.WriteLine("error");

        }
    }
}
