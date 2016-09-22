using System;

class Fibunachi
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num1 = 0;
        int num2 = 1;
        int temp = 0;

            for (int i = 0; i <= n; i++)
            {
                temp = num1;
                num1 = num2;
                num2 += temp;
            }


        Console.WriteLine(num1);
    }
}

