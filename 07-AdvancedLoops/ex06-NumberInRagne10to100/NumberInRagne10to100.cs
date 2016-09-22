using System;

class Sequence2k1
{
    static void Main()
    {
        int n = 0;

        do
        {
            Console.Write("Enter a number in the range [1...100]: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0 && n < 101) break;
            Console.WriteLine("Invalid number!");
        } while (true);
        Console.WriteLine("The number is: " + n);
    }
}