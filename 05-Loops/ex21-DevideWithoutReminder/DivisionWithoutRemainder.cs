using System;


class DivisionWithoutRemainder
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        decimal p1 = 0.0m;
        decimal p2 = 0.0m;
        decimal p3 = 0.0m;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number%2 == 0) p1++;
            if (number%3 == 0) p2++;
            if (number%4 == 0) p3++;

        }

        Console.WriteLine("{0:0.00}%", p1 / n * 100);
        Console.WriteLine("{0:0.00}%", p2 / n * 100);
        Console.WriteLine("{0:0.00}%", p3 / n * 100);
    }
}
