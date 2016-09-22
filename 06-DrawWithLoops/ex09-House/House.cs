using System;

class House
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int top = (n - 1) / 2; // number of times, that top row (--*--) will appear
        int bot = n / 2; // number of times, that bottom row will appear

        for (int i = top; i >= 0; i--) // at least two '*' at the bottom of top rows
        {
            Console.WriteLine(
                new string('-', i) +
                new string('*', n - i * 2) +
                new string('-', i)
                );
        }
        for (int i = 0; i < bot; i++)
        {
            Console.WriteLine(
                '|' +
                new string('*', n - 2) +
                '|'
                );
        }

        
    }
}
