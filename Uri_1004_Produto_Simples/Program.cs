using System;

namespace Uri_1004{
    class Program{
        static void Main(string[]agrs){
            Console.Clear();

            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}