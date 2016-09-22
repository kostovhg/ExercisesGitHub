using System;


class Sunglasses
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write(
                    '*' + 
                    new string(
                        (i == 1 || i == n)?
                        '*':
                        '/', 
                        n*2 -2) +
                    '*');
                Console.Write(
                    new string(
                        (i != (n+1)/2) ?
                        ' ' :
                        '|', 
                        n));
                Console.WriteLine('*' + new string((i == 1 || i == n) ? '*' : '/', n * 2 - 2) + '*');
            }
            //Console.WriteLine();

    }
}

