using System;


class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine(); // type of year
        int p = int.Parse(Console.ReadLine()); // number of holidays
        var h = int.Parse(Console.ReadLine()); // hometown weekends

        double plays = (48 - h) * 3d / 4 + h + p * (2d / 3);
        plays *= (year == "leap") ? 1.15 : 1;
        Console.WriteLine(Math.Floor(plays));

    }
}


