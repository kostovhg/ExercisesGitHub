using System;


class EqualPairs
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int num;
        int sum = 0;
        int oldSum = 0;
        int difference = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            num = int.Parse(Console.ReadLine());
            sum += num; // adding next number
            if (i % 2 == 0)
            {
                // if(i>2) difference = Math.Max(sum, oldSum) - Math.Min(sum, oldSum);
                difference = (i >2) ? Math.Abs(sum - oldSum): 0;
                oldSum = sum;
                sum = (i != n * 2) ? 0 : sum;
            }
        }
        Console.WriteLine(
            (difference == 0) ?
            $"Yes, value={sum}"  : 
            $"No, maxdiff={difference}");
    }
}

