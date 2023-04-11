// See https://aka.ms/new-console-template for more information
Console.Clear();

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

int menor = x;
int maior = y;

if (x > y){
    menor = y;
    maior = x;
}
int soma = 0;
for(int i = menor; i <= maior; i++){
    if(i % 13 != 0){
        soma = soma + i;
    }
}
Console.WriteLine(soma);