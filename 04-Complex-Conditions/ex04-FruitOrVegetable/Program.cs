﻿using System;

namespace ex04_FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            string food = Console.ReadLine();

            if (food == "banana" ||
                food == "apple" ||
                food == "kiwi" ||
                food == "cherry" ||
                food == "lemon" ||
                food == "grapes"
                ) Console.WriteLine("fruit");
            else if (food == "tomato" ||
                food == "cucumber" ||
                food == "pepper" ||
                food == "carrot"
                ) Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
