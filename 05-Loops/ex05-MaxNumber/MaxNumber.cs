using System;

class MaxNumber
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int num;

        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num > max) max = num;
        }
        Console.WriteLine(max);
    }
}

