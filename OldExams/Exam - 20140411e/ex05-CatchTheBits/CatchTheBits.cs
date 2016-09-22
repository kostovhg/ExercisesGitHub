using System;
class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] inNumbers = new int[n];
        int newIndex = 0;

        for (int i = 0; i < n; i++)
        {
            inNumbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n*8; i++)
        {
            if (i/(newIndex*step +1) == 0)
            {

                newIndex++;  
            }
            
        }
    }
}
