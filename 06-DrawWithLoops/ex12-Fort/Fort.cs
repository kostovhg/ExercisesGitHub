using System;

class Fort
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int half = n / 2;
        int quot = 2*(n-2-half);
        quot = (quot > 0) ? quot : 0;

        for (int i = 1; i <= n; i++)
        {
            if (i > 1 && i < n )
            {
                Console.WriteLine(
                    '|' +
                    new string(' ', half + 1) +
                    new string((i != n - 1) ? ' ' : '_', quot) +
                    new string(' ', half + 1) +
                    '|'
                );
            }
            else
            {
                Console.WriteLine(
                    ((i == 1) ? '/' : '\\') +
                    new string((i == 1) ? '^' : '_', half) +
                    ((i == 1) ? '\\' : '/') +
                    new string((i == 1 || i == n - 1) ? '_' : ' ', quot) +
                    ((i == 1) ? '/' : '\\') +
                    new string((i == 1) ? '^' : '_', half) +
                    ((i == 1) ? '\\' : '/')
                );
            }
        }       
        
    }
}
