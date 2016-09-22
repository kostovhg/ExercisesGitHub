using System;

class NumberPyramid
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (num == n+1)
                {
                    break;
                }
                Console.Write(num);
                Console.Write(" " );
                num++;

            }
            Console.WriteLine();
        }
    }
}