﻿// See https://aka.ms/new-console-template for more information
//1. * *Gerar e escrever os números ímpares entre 100 e 200.**
//   - Exemplo de saída: 101, 103, 105, ..., 199.

for (int i = 100; i <= 200; i++)
{
    if ((i % 2) != 0)
        Console.WriteLine("Número ímpar: " + i);
}
