// See https://aka.ms/new-console-template for more information
Console.Clear();

int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;

for (int i = 0; i < n; i = i + 1)
{
    if (i == n - 1)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.Write(a + " ");
    }
    int aux = b;
    b = a;
    a = aux + b;
}
