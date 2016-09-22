using System;

class MagicCarNumbers
{

    static void Main()
    {
        int magWeight = int.Parse(Console.ReadLine());
        int counter = 0;
        int letters = 0;
        char[] symbols = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        foreach (char ch in symbols)
        {
            foreach (char cha in symbols)
            {
                letters = (ch - 64) * 10 + (cha - 64) * 10;
                for (int i = 0; i <= 9; i++)
                {
                    if (magWeight == 40 + (4 * i) + letters)
                    {
                        //Console.Write($"CA{i}{i}{i}{i}{ch}{cha}, ");
                        counter++;
                    }
                    for (int j = 0; j <= 9; j++)
                    {
                        if (j != i)
                        {
                            if (magWeight == 40 + i + j + j + j + letters)
                            {
                                //Console.Write($"CA{i}{j}{j}{j}{ch}{cha}, ");
                                counter++;
                            }
                            if (magWeight == 40 + i + i + i + j + letters)
                            {
                                //Console.Write($"CA{i}{i}{i}{j}{ch}{cha}, ");
                                counter++;
                            }
                            if (magWeight == 40 + i + i + j + j + letters)
                            {
                                //Console.Write($"CA{i}{i}{j}{j}{ch}{cha}, ");
                                counter++;
                            }
                            if (magWeight == 40 + i + j + i + j + letters)
                            {
                                //Console.Write($"CA{i}{j}{i}{j}{ch}{cha}, ");
                                counter++;
                            }
                            if (magWeight == 40 + i + j + j + i + letters)
                            {
                                //Console.Write($"CA{i}{j}{j}{i}{ch}{cha}, ");
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}

