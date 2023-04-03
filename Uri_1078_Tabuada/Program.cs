using System;

namespace uri1078{
    class Program{
        static void Main(string[]agrs){
            Console.Clear();

            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++){
                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado );
            }
        }
    }
}