﻿// See https://aka.ms/new-console-template for more information
Console.Clear();

int n = int.Parse(Console.ReadLine());

int inicio = 1;

for (int i = 1; i <= n; i++)
{

    int segundo = inicio + 1;
    int terceiro = inicio + 2;
    Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");

    inicio = inicio + 4;
}