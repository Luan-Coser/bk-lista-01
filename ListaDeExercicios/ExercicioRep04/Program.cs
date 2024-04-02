// See https://aka.ms/new-console-template for more information
//4. * *Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.**
//   - Exemplo de saída: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} = FizzBuzz");
    }else if (i % 3 == 0)
    {
    Console.WriteLine($"{i} = Fizz");
    }else if (i % 5 == 0)
    {
    Console.WriteLine($"{i} = Buzz");
    }
    else
    {
    Console.WriteLine(i);
    }

}