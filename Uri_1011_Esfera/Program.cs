﻿using System;
using System.Globalization;

namespace Uri_1011_Casting{
    class Program{
        static void Main(string[]agrs){
          Console.Clear();

          double raio, volume;
          raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;
          Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}