using System;

class NumberTable
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                num = j + i + 1;
                if (j + i >= n)
                {
                    Console.Write(2*n - num);
                }
                else
                {
                    Console.Write(num);
                }
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}