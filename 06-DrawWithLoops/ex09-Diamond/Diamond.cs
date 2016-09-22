using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int half = (n - 1) / 2;
        int middle = 0;
        int rows = Math.Max(n - 1, (n %2 ) * n);

        for (int row = 1 ; row <= rows; row++)
        {
            middle = n - (2 * Math.Abs(half) + 2);
            Console.WriteLine(
                new string('-', Math.Abs(half)) +
                '*' + 
                new string('-', (middle>= 0) ? middle : 0) +
                new string('*', (middle >= 0) ? 1 : 0) +
                new string('-', Math.Abs(half))
                );
            half--;
        }
    }
}

