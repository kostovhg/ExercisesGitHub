using System;

class BitInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counter = 0; int bitPoss = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("{0,8}", Convert.ToString(num,2));

            for (int j = 0; j < 8; j++)
            {
                bitPoss = counter - (8 * i );
                if ((counter == 0 || counter%step == 0) && counter-1 != 8*n)
                {
                    num ^= (1 << 7 - bitPoss);
                    //Console.WriteLine("{0,8}", Convert.ToString(num, 2));

                }
                counter++;
            }
            //if (step != 1)
            //{
            //    counter++;
            //}

            Console.WriteLine(num);
        }
    }
}

