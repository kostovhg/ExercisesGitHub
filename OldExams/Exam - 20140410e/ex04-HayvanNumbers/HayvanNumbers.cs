using System;

class HayvanNumbers
{
    static void Main()
    {
        string sSum = Console.ReadLine();
        int iSum = int.Parse(sSum);
        string sDiff = Console.ReadLine();
        int iDiff = int.Parse(sDiff);
        int iNumA = 555;
        int iNumB = 556;
        int iNumC = 557;
        bool bIfAny = false;

        while (iNumC <= 999)
        {
            iNumB = iNumA + iDiff;
            iNumC = iNumB + iDiff;

            if (((DigSum(iNumA) + DigSum(iNumB) + DigSum(iNumC)) == iSum ) &&
                CorrecDigits(iNumA) &&
                CorrecDigits(iNumB) &&
                CorrecDigits(iNumC))
            {
                Console.WriteLine("{0}{1}{2}" , iNumA, iNumB, iNumC);
                bIfAny = true;
            }

            iNumA++;
        }

        if (!bIfAny)
        {
            Console.WriteLine("No");
        }

    }
    static int DigSum(int n)
    {
        int iDigit = n; int iCurrentSum = 0;

        while (iDigit > 0)
        {
            iCurrentSum += iDigit % 10;
            iDigit /= 10;
        }


        return iCurrentSum;
    }

    static bool CorrecDigits(int n)
    {
        bool result = true;
        int iDigit = n; int tempDigit = 0;

        while (iDigit > 0)
        {
            tempDigit = iDigit % 10;
            if (tempDigit < 5)
            {
                result = false;
            }
            iDigit /= 10;
        }

        return result;
    }
}

