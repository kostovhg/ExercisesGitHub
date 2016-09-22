using System;


class WeAllLoveBits
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        //var num = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int[] newNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int num = 0; num < n; num++)
        {
            newNumbers[num] = (numbers[num] ^ (~numbers[num])) & Reverse(numbers[num]);
            Console.WriteLine(newNumbers[num]);
        }
        //byte[] reversedNum = new byte[32];
        //for (int i = 1; i < 32; i++)
        //{
        //    reversedNum[i] = (byte)(num % 2);
        //    num /= 2;
        //    Console.Write(reversedNum[i]);
        //}

    }

    static int Reverse(int input)
    {
        uint x = unchecked((uint)input);
        uint y = 0;
        while (x != 0)
        {
            y <<= 1;
            y |= x & 1;
            x >>= 1;
        }
        return unchecked((int)y);
    }
}
    
