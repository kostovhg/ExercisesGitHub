using System;

class NewHouse
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int half = n / 2;
        int air = half;

        for (int i = 0; i < n- half; i++)
        {
            Console.Write(new string('-', air));
            Console.Write(new string('*', n - 2*air));
            Console.WriteLine(new string('-', air));
            air--;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write('|');
            Console.Write(new string('*', n -2));
            Console.WriteLine('|');
        }
    }
}
