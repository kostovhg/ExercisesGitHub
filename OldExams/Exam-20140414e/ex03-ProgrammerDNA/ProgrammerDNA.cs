using System;


class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = (char)Console.Read();
        int count = 0;
        int dots = 0;
        int symbols = 0;


        while (true)
        {
            for (int i = 0; i < 7; i++)
            {
                dots = Math.Abs(3 - i % 7);
                symbols = Math.Abs(7 - 2 * dots);
                Console.Write(new string('.', dots));
                for (int j = 1; j <= symbols; j++)
                {
                    if (letter > 'G')
                    {
                        letter = 'A';
                    }
                    Console.Write(letter);
                    letter++;
                }
                Console.WriteLine(new string('.', dots));
                if (count < n -1) count++;
                else return;
            }
        } 
    }
}
