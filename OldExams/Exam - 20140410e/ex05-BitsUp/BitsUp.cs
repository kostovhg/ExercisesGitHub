using System;


class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 7; j >= 0; j--)
            {
                if ((step == 1 && counter > 0) || counter%step == 1  )
                {
                    num |= (1 << j);
                }
                counter++;
            }

            Console.WriteLine(num);
        }


    }
}
