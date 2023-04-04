// See https://aka.ms/new-console-template for more information
Console.Clear();

int n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    if (i % 2 == 0)
    {
        int quadrado = i * i;
        Console.WriteLine(i + "^2 = " + quadrado);
    }
}
