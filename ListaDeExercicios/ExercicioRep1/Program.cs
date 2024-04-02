// See https://aka.ms/new-console-template for more information
//1. * *Verificar se a soma de A + B é menor que C.**
//   - Exemplo de entrada: A = 5, B = 3, C = 10
//   - Exemplo de saída: A + B é menor que C.

int a, b, c;

Console.Write("A: ");
a = Convert.ToInt16(Console.ReadLine());
Console.Write("B: ");
b = Convert.ToInt16(Console.ReadLine());
Console.Write("C: ");
c = Convert.ToInt16(Console.ReadLine());

if ((a+b) < c)
{
    Console.WriteLine("A + B é menor que C");
}
else
{
    Console.WriteLine("A + B é maior que C");
}