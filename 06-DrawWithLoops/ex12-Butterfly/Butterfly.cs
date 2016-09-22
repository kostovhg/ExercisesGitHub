using System;

class Butterfly
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        int rep = n - 2;
        int rows = 2 * rep + 1;
        string stars = new string('*', rep);
        string dashes = new string('-', rep);

        for (int i = 1; i <= rows ; i++)
        {
            if (i != n-1)
            {
                Console.WriteLine(
                    ((i % 2 != 0) ? stars : dashes) +
                    ((i < rep + 1) ? '\\' : '/') +
                    ' ' +
                    ((i < rep + 1) ? '/' : '\\') +
                    ((i % 2 != 0) ? stars : dashes)
                );
            }
            else
            {
                Console.WriteLine(
                    new string(' ', rep +1 ) +
                    '@' +
                    new string(' ', rep + 1)
                );
            }
        }
    }
}
