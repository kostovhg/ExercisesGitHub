using System;

class TriangleOfDollars
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i <n ; i++)
        {
            Console.Write('$');
            for (int j = 0; j < i; j++)
            {
                Console.Write(' ');
                Console.Write('$');
            }
            Console.WriteLine();
          
        }
    }
}