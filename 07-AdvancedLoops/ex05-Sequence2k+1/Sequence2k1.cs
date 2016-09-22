using System;

class Sequence2k1
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int num = 1; num <= n; num = num * 2 + 1)
        {
            Console.WriteLine(num);
        }
    }
}
