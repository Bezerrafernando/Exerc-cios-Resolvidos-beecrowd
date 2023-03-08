// See https://aka.ms/new-console-template for more information
Console.Clear();

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

int Cont = 0;
if(a % 2 == 0){
    Cont = Cont + 1;
}
if(b % 2 == 0){
    Cont = Cont + 1;
}
if(c % 2 == 0){
    Cont = Cont + 1;
}
if(d % 2 == 0){
    Cont = Cont + 1;
}
if(e % 2 == 0){
    Cont = Cont + 1;
}

Console.WriteLine(Cont + " valores pares");

