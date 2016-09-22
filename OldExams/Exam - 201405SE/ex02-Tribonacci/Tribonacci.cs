using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger num1 = BigInteger.Parse(Console.ReadLine());
        BigInteger num2 = BigInteger.Parse(Console.ReadLine());
        BigInteger num3 = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger cNum = 0;

        switch (n)
        {
            case 1: cNum = num1; break;
            case 2: cNum = num2; break;
            case 3: cNum = num3; break;
            default:
                for (int i = 1; i <= n - 3; i++)
                {
                    cNum = num1 + num2 + num3;
                    num1 = num2;
                    num2 = num3;
                    num3 = cNum;
                }

                break;
        }

        Console.WriteLine(cNum);
    }
}

