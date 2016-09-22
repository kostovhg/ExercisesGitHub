using System;

class StopSign
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        int rows = 2 * n + 2;
        int col = rows * 2 - 1;
        int dots = n + 1;

        for (int i = 1; i <= rows; i++)
        {
            if (i == 1)
            {
                Console.WriteLine(
                     new string('.', dots) +
                     new string('_', col - 2* dots) +
                     new string('.', dots)
                 );
            }
            else if (i == n+2 )
            { 
                dots++;
                Console.WriteLine(
                    "//" +
                    new string('_', (col - 9) / 2) +
                    "STOP!" +
                    new string('_', (col - 9) / 2) +
                    '\\' + '\\'
                );
                
            }
            else
            {
                Console.WriteLine(
                    new string('.', Math.Abs(dots )) +
                    ((i > n + 2) ? "\\\\" : "//") +
                    new string('_', col - Math.Abs(2 * dots) - 4) +
                    ((i > n + 2) ? "//" : "\\\\") +
                    new string('.', Math.Abs(dots ))
                );
            }
            dots--;
        }

    }
}

