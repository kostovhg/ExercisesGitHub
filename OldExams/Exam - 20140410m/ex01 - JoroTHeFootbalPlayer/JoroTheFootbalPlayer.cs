using System;

class JoroTheFootbalPlayer
{
    static void Main(string[] args)
    {
        char leap = char.Parse(Console.ReadLine());
        int holidays = int.Parse(Console.ReadLine());
        int hometown = int.Parse(Console.ReadLine());
        int normal = 52 - hometown;
        double plays = (normal / 3d) * 2 + hometown + holidays / 2d;

        if (leap == 't')
        {
            plays += 3;
        }

        Console.WriteLine(Math.Floor(plays));
    }
}

