using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(x, 2));

            int y = 0;
            Console.WriteLine("{0,32}{1,32}{2,32}", "y <<=1", "y |= x & 1", "y >>= 1");
            while (x != 0)
            {
                y <<= 1;
                Console.Write("{0,32}", Convert.ToString(y, 2));
                y |= x & 1;
                Console.Write("{0,32}", Convert.ToString(y, 2));
                x >>= 1;
                Console.WriteLine("{0,32}", Convert.ToString(x, 2));
            }

            Console.WriteLine(y);
        }

    }

}
