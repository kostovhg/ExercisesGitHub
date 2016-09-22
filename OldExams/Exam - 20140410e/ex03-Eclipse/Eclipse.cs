using System;

class Eclipse
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        bool end = true;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                end = true;
            }
            else
            {
                end = false;
            }
            string sSides = new string((end) ? ' ' : '*', 1);
            string sInner = new string((!end) ? '/' : '*', n * 2 - 2);
            string sBridge = new string((i == (n + 1 ) / 2) ? '-' : ' ', n - 1);

            Console.WriteLine(
                sSides + sInner + sSides + sBridge +sSides + sInner + sSides
                );
        }
    }
}

