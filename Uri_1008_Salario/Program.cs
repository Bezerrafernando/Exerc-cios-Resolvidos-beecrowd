using System.Globalization;
// See https://aka.ms/new-console-template for more information

int numero, horas;
double valorHora, salario;

numero = int.Parse(Console.ReadLine());
horas = int.Parse(Console.ReadLine());
valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


salario = valorHora * horas;

Console.WriteLine("NUMBER = " + numero);
Console.WriteLine("SALARY = U$ "+ salario.ToString("F2", CultureInfo.InvariantCulture));


