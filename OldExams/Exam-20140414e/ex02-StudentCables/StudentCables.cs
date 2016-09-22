using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int length = 0; // sum of cables in cm
        int connections = -1; // number of pieces
        int cable = 0; // separate cable length
        int cables = 0; // avaiable cables after geting pieces together

        for (int i = 0; i < n; i++)
        {
            cable  = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            if (!(cable < 20 && type == "centimeters"))
            {
                connections++;
                length += cable * ((type == "meters") ? 100 : 1);
            }
        }
        cables = (length - 3 * (connections)) / 504;
        length = length - 3 * (connections);
        Console.WriteLine(cables);
        Console.WriteLine(length - cables * 504);
    }
}
