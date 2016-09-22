using System;

class LoopsByStep3
{
    static void Main()
    {
        Console.WriteLine("n = ");
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine("THe numbers are:");
        for (int i = 1; i <= n; i+= 3)
        {
            Console.WriteLine(i);
        }
    }
}
