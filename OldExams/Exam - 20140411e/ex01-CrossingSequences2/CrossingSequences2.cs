using System;

class CrossingSequences2
{
    static void Main(string[] args) // with arrays
    {
        // First read three numbers and calculate all Tribonacci members
        // up to 1 000 000
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());

        // Find number of members lower than 1 000 000 and use this count
        // as top border for all other loops
        int iMax = 0, counter = 3;
        int tmpT1 = t1;
        int tmpT2 = t2;
        int tmpT3 = t3;
        while (true)
        {
            iMax = tmpT1 + tmpT2 + tmpT3;
            if (iMax > 1000000) break; // extit before go over 1000000
            tmpT1 = tmpT2;
            tmpT2 = tmpT3;
            tmpT3 = iMax;
            counter++; // Console.WriteLine($"{counter} {iMax}"); // for check
        }

        // fill Array with Tribonacci members
        int[] trib = new int[counter];
        for (int i = 2; i < trib.Length; i++)
        {
            if (i != 2)
            {
                trib[i] = t1 + t2 + t3;
                t1 = trib[i - 2];
                t2 = trib[i - 1];
                t3 = trib[i];//Console.WriteLine($"{i} -> {trib[i]}"); // for check
            }
            else
            {
                trib[0] = t1; //Console.WriteLine($"0-> {trib[0]}"); // for check
                trib[1] = t2; //Console.WriteLine($"1-> {trib[1]}"); // for check
                trib[2] = t3; //Console.WriteLine($"2-> {trib[2]}"); // for check
            }
        }

        // Ask for first member and step for number spiral
        int s1 = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        // find upper border of spiral array, with member <= 1000000
        int tmpS = s1;
        int turn = 1;
        bool corner = false;
        counter = 1; // restart the counter, it is 1 because we have s1 already

        while (true)
        {
            tmpS += step * turn;
            if (tmpS > 1000000) break; // extit before go over 1000000
            if (corner) turn++; // add 1 step more befor the turn of direction
            counter++;
            corner = !corner; // Console.WriteLine($"{counter} -> {tmpS}"); // for check
        }

        // Fill the spiral array
        int[] spiral = new int[counter];
        turn = 1; // turn to 1 to use it again

        for (int i = 0; i < spiral.Length; i++)
        {
            if (i != 0)
            {
                spiral[i] = spiral[i - 1] + step * turn;
                if (i % 2 == 0) turn++;
            }
            else
            {
                spiral[0] = s1;
            } // Console.WriteLine($"{i} -> {spiral[i]}"); // for check
        }

        // Now we have two arrays, and we need two nested loops to go trough all
        // members of two sequences
        bool match = false;

        for (int i = 0; i < trib.Length; i++)
        {
            // next loop will be limited to the length of spiral and checket values
            for (int j = 0; j < spiral.Length && spiral[j] <= trib[i]; j++)
            {
                if (spiral[j] == trib[i])
                {
                    match = true;
                    Console.WriteLine(spiral[j]); break; // exit second loop
                }
            }
            if (match) break; // exit firtst loop
        }

        if (!match) Console.WriteLine("No");
    }
}