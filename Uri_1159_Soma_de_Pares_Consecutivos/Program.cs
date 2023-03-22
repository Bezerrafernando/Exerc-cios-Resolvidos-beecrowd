// See https://aka.ms/new-console-template for more information
Console.Clear();

int x = int.Parse(Console.ReadLine());

while(x != 0){
    // se for impar, some mais 1
    if(x % 2 != 0){
        x = x + 1;
    }

    //expressão simplificada: 5 * x + 20
    int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
    Console.WriteLine(soma);

    x = int.Parse(Console.ReadLine()); 
}