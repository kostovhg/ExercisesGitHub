﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trangle_Area
{
    class TrangleArea
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a * h) / 2;
            Console.WriteLine("Trangle area = {0}", Math.Round(area, 2));
        }
    }
}