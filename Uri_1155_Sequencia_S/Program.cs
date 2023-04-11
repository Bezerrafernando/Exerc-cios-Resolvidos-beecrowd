// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.Clear();

double soma = 0;
for(int i = 1; i <= 100; i++){
    soma = soma + 1.0; 
}
Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));