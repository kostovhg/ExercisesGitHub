using System;

class SmartLilly
{
    static void Main(string[] args)
    {
        int age = int.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());
        decimal money = 0;
        int toys = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i%2 != 0)
            {
                toys++;
            }
            else
            {
                money += (10 * (i / 2)) -1;
            }
        }
        money += (toys * toyPrice);

        Console.WriteLine(
            (price <= money) ?
            "Yes! {0:0.00}" :
            "No! {1:0.00}"
            , (money - price), (price - money));
    }
}

