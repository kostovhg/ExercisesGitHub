using System;

class OddOrEvenSum
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int num = 0;
        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 2; i <= n+1; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (i%2!=0)
            {
                sumOdd += num;
            }
            else
            {
                sumEven += num;
            }
        }


        Console.WriteLine(
            sumOdd == sumEven ?
            "Yes Sum = " + sumOdd :
            "No Diff = " + Math.Abs(sumOdd - sumEven)
            );

    }
}