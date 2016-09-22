using System;


class Histogram
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        decimal p1 = 0.0m;
        decimal p2 = 0.0m;
        decimal p3 = 0.0m;
        decimal p4 = 0.0m;
        decimal p5 = 0.0m;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 200) p1++;
            else if (number < 400) p2++;
            else if (number < 600) p3++;
            else if (number < 800) p4++;
            else p5++;
        }

        Console.WriteLine("{0:p2}", p1 / n );
        Console.WriteLine("{0:p2}", p2 / n );
        Console.WriteLine("{0:p2}", p3 / n );
        Console.WriteLine("{0:p2}", p4 / n );
        Console.WriteLine("{0:p2}", p5 / n );
    }
}

