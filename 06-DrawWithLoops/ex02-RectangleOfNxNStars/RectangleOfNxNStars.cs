﻿using System;

class RectangleOfNxNStars
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', n));
        }
    }
}