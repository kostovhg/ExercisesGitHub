using System;

class ChristmasTree
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.Write(new string(' ',n+1));
        Console.WriteLine('|');
        for (int i = 1; i <= n ; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.Write(new string('*', i));
            Console.Write(" | ");
            Console.WriteLine(new string('*', i));

        }
        Console.WriteLine();
    }
}
