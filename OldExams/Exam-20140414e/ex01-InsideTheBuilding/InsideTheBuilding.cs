using System;


class InsideTheBuilding
{
    static void Main()
    {
        int[,] coordinates = new int[5, 2];
        int h = int.Parse(Console.ReadLine());

        for (int i = 0; i <= coordinates.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= coordinates.GetUpperBound(1); j++)
            {
                coordinates[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //int x1 = int.parse(console.readline());
        //int y1 = int.parse(console.readline());
        //int x2 = int.parse(console.readline());
        //int y2 = int.parse(console.readline());
        //int x3 = int.parse(console.readline());
        //int y3 = int.parse(console.readline());
        //int x4 = int.parse(console.readline());
        //int y4 = int.parse(console.readline());
        //int x5 = int.parse(console.readline());
        //int y5 = int.parse(console.readline());

        int iDownBottom = 0;
        int iDownTop = h;
        int iDownLeft = 0;
        int iDownRight = 3 * h;
        int iUpBottom = iDownTop;
        int iUpTop = 4 * h;
        int iUpLeft = h;
        int iUpRight = 2 * h;
        bool inside = false;

        for (int p = 0; p <= coordinates.GetUpperBound(0); p++)
        {
            if (
                (
                coordinates[p, 0] >= iDownLeft &&
                coordinates[p, 0] <= iDownRight &&
                coordinates[p, 1] >= iDownBottom &&
                coordinates[p, 1] <= iDownTop
                ) ||
                (
                coordinates[p, 0] >= iUpLeft &&
                coordinates[p, 0] <= iUpRight &&
                coordinates[p, 1] >= iUpBottom &&
                coordinates[p, 1] <= iUpTop
                )
                ) inside = true;
            else inside = false;

            Console.WriteLine((inside)? "inside" : "outside");
        }


    }
}

