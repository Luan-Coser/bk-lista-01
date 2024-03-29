// See https://aka.ms/new-console-template for more information
//4. * *Identificar se um número é par ou ímpar.**
//   - Exemplo de entrada: Número = 7
//   - Exemplo de saída: O número é ímpar.

int n;
float resto;

Console.WriteLine("Numero: ");
n = Convert.ToInt32(Console.ReadLine());

resto = n % 2;
if ( resto == 0)
{
    Console.Write("O numero é par");

}
else
{
    Console.Write("O numero é impar");
}


