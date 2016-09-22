using System;

class CheckPrime
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        int divider = 2;
        int maxDivider = (int)Math.Sqrt(num);
        bool prime = true;

        if (num > 1)
        {
            while (prime && (divider <= maxDivider) && num > 1)
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine((prime)?"Prime":"Not Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
        
    }
}