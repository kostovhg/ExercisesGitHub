using System;

class SandGlass
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int half = (n - 1) / 2;
        int dots = 0;
        int stars = half;

        for (int i = 0; i < n; i++)
        {
            stars = Math.Abs(half - i);
            dots = half - stars;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.Write('*');
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));
        }
    }
}

