using System;


class OddEvenPositions
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        double num;
        double maxOdd = double.MinValue;
        double minOdd = double.MaxValue;
        double maxEven = double.MinValue;
        double minEven = double.MaxValue;
        double sumOdd = 0;
        double sumEven = 0;

        for (int i = 2; i <= n+1; i++)
        {
            num = double.Parse(Console.ReadLine());
            if (i%2 == 0)
            {
                
                maxOdd = (maxOdd < num) ? num : maxOdd;
                minOdd = (minOdd > num) ? num : minOdd;
                sumOdd += num;
            }
            else
            {
                
                maxEven = (maxEven < num) ? num : maxEven;
                minEven = (minEven > num) ? num : minEven;
                sumEven += num;
            }
        }

        Console.WriteLine(
            "OddSum=" + sumOdd + ",\n" +
            "OddMin=" + ((minOdd != double.MaxValue)? $"{minOdd}" : "No") + ",\n" +
            "OddMax=" + ((maxOdd != double.MinValue) ? $"{maxOdd}" : "No") + ",\n" +
            "EvenSum=" + sumEven + ",\n" +
            "EvenMin=" + ((minEven != double.MaxValue) ? $"{minEven}" : "No") + ",\n" +
            "EvenMax=" + ((maxEven != double.MinValue) ? $"{maxEven}" : "No") + "\n"
            );
    }
}
