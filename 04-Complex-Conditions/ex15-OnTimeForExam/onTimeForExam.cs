using System;


class onTimeForExam
{
    static void Main(string[] args)
    {
        var exHour = int.Parse(Console.ReadLine());
        var exMinutes = int.Parse(Console.ReadLine());
        var arrHour = int.Parse(Console.ReadLine());
        var arrMinutes = int.Parse(Console.ReadLine());

        string onTime = ""; 
        int exTime = exHour * 60 + exMinutes;
        int arrTime = arrHour * 60 + arrMinutes;
        int difference = exTime - arrTime;
        int hours = difference/60;
        int minutes = difference - hours * 60;

        if (difference < 0 )
        {
            onTime = "Late";
        }
        else if (difference > 30)
        {
            onTime = "Early";
        }
        else
        {
            onTime = "On time";
        }

        Console.WriteLine(onTime);

        if (difference >= 60)
        {
            Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
        }
        else if (difference > 0)
        {
            Console.WriteLine("{0} minutes before the start", minutes);
        }
        else if (difference <= -60)
        {
            Console.WriteLine("{0}:{1:00} hours after the start", Math.Abs(hours), Math.Abs(minutes));
        }
        else if (difference < 0)
        {
            Console.WriteLine("{0} minutes after the start", Math.Abs(minutes));
        }
    }
}
