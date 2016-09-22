using System;

class Illuminati
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine().ToLower();
        int count = 0;
        int sum = 0;

        foreach (var ch in message)
        {
            switch (ch)
            {
                case 'a':
                    sum += 65;
                    count++;
                    break;
                case 'e':
                    sum += 69;
                    count++;
                    break;
                case 'i':
                    sum += 73;
                    count++;
                    break;
                case 'o':
                    sum += 79;
                    count++;
                    break;
                case 'u':
                    sum += 85;
                    count++;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}

