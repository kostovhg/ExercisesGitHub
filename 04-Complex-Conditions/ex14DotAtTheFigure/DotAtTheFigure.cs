using System;

class DotAtTheFigure
{
    static void Main(string[] args)
    {
        var h = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        // long variant
        int dLeft = 0; // down figure left border/ x min
        int dRight = h * 3; // down figure right border / x max
        int uLeft = h; // up figure left border / x min
        int uRight = h * 2; // up figure right border / x max 
        int dBottom = 0; // down figure bottom border / y min
        int dTop = h; // down figure top border / y max
        int uBottom = h; // up figure bottom border / y min
        int uTop = h * 4; // up figure top border / y max


    }
}

