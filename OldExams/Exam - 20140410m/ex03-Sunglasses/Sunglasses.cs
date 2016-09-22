using System;

class Sunglasses
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        string lens = '*' + new string('/', 2*n - 2) + '*';
        string hFrames = new string('*', 2 * n);
        string bridge = new string('|', n);
        string spaces = new string(' ', n);

        for (int i = 1; i <= n; i++)
        {
            if (i != 1 && i != n)
            {
                Console.Write(lens);
                Console.Write((i != (n/2 +1))? spaces : bridge);
                Console.WriteLine(lens);
            }
            else
            {
                Console.Write(hFrames);
                Console.Write(spaces);
                Console.WriteLine(hFrames);
            }
        }

    }
}
