using System;

class trip
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        string destination = "";
        string respiteType = "";
        double spendings =  0.0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            switch (season)
            {
                case "summer":
                    respiteType = "Camp";
                    spendings = 0.3 * budget ;
                    break;
                case "winter":
                    respiteType = "Hotel";
                    spendings = 0.7 * budget;
                    break;
            }

        }

        else if (budget <= 1000)
        {
            destination = "Balkans";
            switch (season)
            {
                case "summer":
                    respiteType = "Camp";
                    spendings = 0.4 * budget;
                    break;
                case "winter":
                    respiteType = "Hotel";
                    spendings = 0.8 * budget;
                    break;
            }

        }
        else
        {
            destination = "Europe";
            respiteType = "Hotel";
            spendings = 0.9 * budget;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine("{0} - {1:F2}", respiteType, spendings);
    }
}

