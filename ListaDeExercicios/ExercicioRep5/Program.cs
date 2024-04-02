// See https://aka.ms/new-console-template for more information
//5. * *Realizar uma operação com base em dois valores inteiros A e B.**
//- Exemplo de entrada: A = 3, B = 3
//- Exemplo de saída: A + B = 6.

int n1, n2, resultado;

Console.WriteLine("Numero 1:");
n1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Numero 2:");
n2 = Convert.ToInt16(Console.ReadLine());

resultado = n1 + n2;

Console.WriteLine($"{n1} + {n2} = {resultado} ");
