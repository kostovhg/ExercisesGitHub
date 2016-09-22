using System;

class MinNumber
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int num;

        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num < min) min = num;
        }
        Console.WriteLine(min);
    }
}
