using System;


class HalfSumElement
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int num;
        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            num = int.Parse(Console.ReadLine());
            max = num > max ? num : max;
            sum += num;
        }

        Console.WriteLine(
            sum - max == max ?
            "Yes Sum = " + max :
            "No Diff = " + Math.Abs(2 *max - sum) );
    }
}
