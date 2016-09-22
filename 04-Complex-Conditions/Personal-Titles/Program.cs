using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal age = decimal.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (age >= 16)
            {
                if (sex == "f") Console.WriteLine("Ms.");
                if (sex == "m") Console.WriteLine("Mr.");     
            }
            else
            {
                if (sex == "f") Console.WriteLine("Miss");
                if (sex == "m") Console.WriteLine("Master");
            }
        }
    }
}
