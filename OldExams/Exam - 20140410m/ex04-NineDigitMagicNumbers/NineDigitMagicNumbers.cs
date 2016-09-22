using System;

class NineDigitMagicNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool condition = false; bool answer = false;
        int A = 0; int B = 0; int C = 0;

        for (A = 111; A <= 777; A++)
        {
            B = A + diff;
            C = A + 2 * diff;

            condition = ((DigitSum(A) + DigitSum(B) + DigitSum(C)) == sum ) &&
                (CorrectDigits(A) && CorrectDigits(B) && CorrectDigits(C));
            if (condition)
            {
                Console.WriteLine("{0}{1}{2}", A, B, C);
                answer = true;
            }
        }
        if (!answer)
        {
            Console.WriteLine("No");
        }
    }

    static int DigitSum(int n)
    {
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    static bool CorrectDigits(int n)
    {
        bool correct = true;
        for (int i = 0; i < 3; i++)
        {
            if ((n % 10 == 0) || (n % 10 > 7))
            {
                correct = false;
            } 
            n /= 10;
        }
        return correct;
    }
}
