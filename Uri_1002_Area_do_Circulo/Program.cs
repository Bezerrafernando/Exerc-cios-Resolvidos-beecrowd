﻿using System;
using System.Globalization;

namespace Uri_1002{
    class Program{
        static void Main(string[]agrs){
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R  * R;
            Console.WriteLine("A="  + A.ToString ("F4" , CultureInfo.InvariantCulture));
        }
    }
}