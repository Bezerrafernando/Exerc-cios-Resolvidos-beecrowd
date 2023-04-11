// See https://aka.ms/new-console-template for more information
Console.Clear();

int n = int.Parse(Console.ReadLine());

int fatorial = 1;
for (int i = 1; i <= n; i++)
{
    fatorial = fatorial * i;
}
Console.WriteLine(fatorial);
