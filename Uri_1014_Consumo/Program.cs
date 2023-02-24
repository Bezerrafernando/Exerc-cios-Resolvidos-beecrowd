using System;
using System.Globalization;

namespace Uri_1014{
    class Program{
        static void Main(string[]agrs){
            Console.Clear();

            int X;
            double Y, Kml;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Kml = (double)X / Y;

            Console.WriteLine(Kml.ToString("F3", CultureInfo.InvariantCulture) + " km/l");      
        }
    }
}