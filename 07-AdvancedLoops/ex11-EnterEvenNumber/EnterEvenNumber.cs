using System;

class EnterEvenNumber
{
    static void Main()
    {
        var num = 1;
        bool result = false;

        while(!result)
        {
            Console.Write("Enter even number: ");
            result = int.TryParse(Console.ReadLine(), out num);

            if (result && num%2 == 0)
            {
                Console.WriteLine("Even number entered: " + num);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
                result = false;
            }
        }
    }
}
