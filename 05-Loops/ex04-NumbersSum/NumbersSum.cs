using System;

class NumbersSum
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var digit = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            digit = int.Parse(Console.ReadLine());
            sum += digit;
        }
        Console.WriteLine(sum);
    }
}

