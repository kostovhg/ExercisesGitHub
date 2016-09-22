using System;

class EnterEvenNumber2
{
    static void Main()
    {
        bool result = true;
        int num = 0;

        while (result)
        {
            try
            {
                Console.Write("Enter even number: ");
                num = int.Parse(Console.ReadLine());
                if (num%2 ==0)
                {
                    Console.WriteLine("Even number entered: " + num);
                    result = false;
                }
                else
                {
                    Console.WriteLine("The number is not even.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

