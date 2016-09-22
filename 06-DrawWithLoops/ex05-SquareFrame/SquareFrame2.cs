using System;

class SquareFrame2
{
    static void Main2(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                if (col == 1) Console.Write(
                        ((row == 1 ||
                        row == n) ?
                        '+' : '|') + " ");
                else if (col == n) Console.Write(
                        (row == 1 ||
                        row == n) ?
                        '+' : '|');
                else Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}
