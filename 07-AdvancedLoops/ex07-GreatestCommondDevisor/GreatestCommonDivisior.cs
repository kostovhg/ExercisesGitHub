using System;

class GreatestCommonDivisior
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3;

        int max = Math.Max(num1, num2);
        int min = Math.Min(num1, num2);

        while(min != 0)
        {
            num3 = max % min;
            max = min;
            min = num3;
        }
        Console.WriteLine(max);
    }
}
