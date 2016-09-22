using System;

class LeftRigthSum
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        int num = 0;
        int sumL = 0;
        int sumR = 0;

        for (int i = 0; i <= n*2; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (i<n)
            {
                sumL += num;
            }
            else
            {
                sumR += num;
            }
        }   


        Console.WriteLine(
            sumL == sumR ? 
            "Yes, sum = " + sumL :
            "No, diff = " + Math.Abs(sumL - sumR)
            );
    }
}
