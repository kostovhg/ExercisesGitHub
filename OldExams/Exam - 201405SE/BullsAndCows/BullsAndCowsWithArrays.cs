using System;

namespace BullsAndCowsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNum = Console.ReadLine();
            int targetBulls = int.Parse(Console.ReadLine());
            int targetCows = int.Parse(Console.ReadLine());

            bool solutionFound = false;

            // loop trought all four digit numbers
            for (int candidate = 1111; candidate <= 9999; candidate++)
            {
                char[] digits = candidate.ToString().ToCharArray();
                if (digits[0] >= '1' && digits[1] >= '1' &&
                    digits[2] >= '1' && digits[3] >= '1')
                {
                    char[] guess = secretNum.ToCharArray();
                    int bulls = 0;
                    int cows = 0;

                    #region FindBulls
                    for (int i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == digits[i])
                        {
                            bulls++;
                            guess[i] = '*';
                            digits[i] = '@';
                        }
                    } 
                    #endregion

                    for (int guessIndex = 0; guessIndex < guess.Length; guessIndex++)
                    {
                        for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                        {
                            if (guess[guessIndex] == digits[digitsIndex])
                            {
                                cows++;
                                guess[guessIndex] = '*';
                                digits[digitsIndex] = '@';
                            }
                        }
                    }

                    if (bulls == targetBulls && cows == targetCows)
                    {
                        if (solutionFound)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(candidate);
                        solutionFound = true;
                    }
                }
            }

            if (!solutionFound)
            {
                Console.WriteLine("No");
            }
        }

    }
}
