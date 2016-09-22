using System;


class Cinema
{
    static void Main(string[] args)
    {
        string sType = Console.ReadLine();
        int iRows = int.Parse(Console.ReadLine());
        int iColumns = int.Parse(Console.ReadLine());
        decimal mPrice, mIncome = 0;

        if (sType=="Premiere")
        {
            mPrice = 12.00m;
        }
        else if (sType == "Discount")
        {
            mPrice = 5.00m;
        }
        else
        {
            mPrice = 7.50m;
        }

        mIncome = (iRows * iColumns) * mPrice;

        Console.WriteLine("{0:0.00} leva", mIncome);
    }
}
