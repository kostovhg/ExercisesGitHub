using System;


class BitFlipper
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int bit = 62;
        while (bit > 0)
        {
            bit--;
            ulong last3Bits = (num >> bit) & 7;
            if (last3Bits == 0 || last3Bits == 7)
            {
                num ^= ((ulong)7 << bit);
                bit -= 2;
            }
        }

        Console.WriteLine(num);
    }
}

