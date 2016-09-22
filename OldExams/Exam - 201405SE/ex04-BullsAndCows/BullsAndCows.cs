using System;

class BullsAndCows
{
    static void Main()
    {
        // read secretNumber, required num of Bulls and Cows
        int guessNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool result = false;

        // generate all 4 digit numbers
        for (int i = 1000; i <= 9999; i++)
        {
            int currentBulls = 0;
            int currentCows = 0;

            int currentNumber = i;
            int currentD = currentNumber % 10;
            currentNumber /= 10;
            int currentC = currentNumber % 10;
            currentNumber /= 10;
            int currentB = currentNumber % 10;
            currentNumber /= 10;
            int currentA = currentNumber % 10;

            int tempGuessNumber = guessNumber;
            int guessNumD = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumC = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumB = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumA = tempGuessNumber % 10;

            if (currentA == 0 || currentB == 0 ||
                currentC == 0 || currentD == 0)
            {
                continue;
            }

            #region FindBulls
            if (currentA == guessNumA)
            {
                currentBulls++;
                currentA = -1;
                guessNumA = -2;
            }

            if (currentB == guessNumB)
            {
                currentBulls++;
                currentB = -1;
                guessNumB = -2;
            }

            if (currentC == guessNumC)
            {
                currentBulls++;
                currentC = -1;
                guessNumC = -2;
            }

            if (currentD == guessNumD)
            {
                currentBulls++;
                currentD = -1;
                guessNumD = -2;
            }
            #endregion
            #region FindCows
            #region currentA
            if (currentA == guessNumB)
            {
                currentCows++;
                currentA = -1;
                guessNumB = -2;
            }

            if (currentA == guessNumC)
            {
                currentCows++;
                currentA = -1;
                guessNumD = -2;
            }

            if (currentA == guessNumD)
            {
                currentCows++;
                currentA = -1;
                guessNumD = -2;
            }
            #endregion

            #region currentB

            if (currentB == guessNumC)
            {
                currentCows++;
                currentB = -1;
                guessNumC = -2;
            }

            if (currentB == guessNumD)
            {
                currentCows++;
                currentB = -1;
                guessNumD = -2;
            }

            if (currentB == guessNumA)
            {
                currentCows++;
                currentB = -1;
                guessNumA = -2;
            }
            #endregion

            #region currentC
            if (currentC == guessNumA)
            {
                currentCows++;
                currentC = -1;
                guessNumA = -2;
            }

            if (currentC == guessNumB)
            {
                currentCows++;
                currentC = -1;
                guessNumB = -2;
            }

            if (currentC == guessNumD)
            {
                currentCows++;
                currentC = -1;
                guessNumD = -2;
            }
            #endregion

            #region CurrentD

            if (currentD == guessNumA)
            {
                currentCows++;
                currentD = -1;
                guessNumA = -2;
            }

            if (currentD == guessNumB)
            {
                currentCows++;
                currentD = -1;
                guessNumB = -2;
            }

            if (currentD == guessNumC)
            {
                currentCows++;
                currentD = -1;
                guessNumC = -2;
            } 
            #endregion
            #endregion

            // TODO: find them

            if (currentBulls == bulls && currentCows == cows)
            {
                result = true;
                Console.Write("{0} ", i);
            }
        }
        if (!result)
        {
            Console.WriteLine("No");
        }
    }

}

