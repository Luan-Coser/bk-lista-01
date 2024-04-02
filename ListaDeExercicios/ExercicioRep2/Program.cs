// See https://aka.ms/new-console-template for more information
//2. * *Ordenar três valores inteiros e diferentes em ordem decrescente.**
//   - Exemplo de entrada: 5, 10, 3
//   - Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.

int a, b, c;


Console.Write("A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("B: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("C: ");
c = Convert.ToInt32(Console.ReadLine());

if (a >= b && b >= c)
{
    Console.WriteLine($"Os números em ordem decrescente são: {a}, {b}, {c}");
}
else if (a >= c && c >= b)
{
    Console.WriteLine($"Os números em ordem decrescente são: {a}, {c}, {b}");
}
else if (b >= a && a >= c)
{
    Console.WriteLine($"Os números em ordem decrescente são: {b}, {a}, {c}");
}
else if (b >= c && c >= a)
{
    Console.WriteLine($"Os números em ordem decrescente são: {b}, {c}, {a}");
}
else if (c >= a && a >= b)
{
    Console.WriteLine($"Os números em ordem decrescente são: {c}, {a}, {b}");
}
else if (c >= b && b >= a)
{
    Console.WriteLine($"Os números em ordem decrescente são: {c}, {b}, {a}");
}