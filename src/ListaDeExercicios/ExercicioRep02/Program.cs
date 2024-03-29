// See https://aka.ms/new-console-template for more information
//2. * *Calcular o fatorial de um número e exibir o resultado.**
//   - Exemplo de entrada: Número = 5
//   - Exemplo de saída: 5! = 120.

float n = 5, fatorial = 1;
Boolean sair = false;

while(sair != true)
{
    
    if (n != 0 )
    {
        fatorial = fatorial * n;
    }else
    {
        sair = true;
    }
    n = n - 1;
    Console.WriteLine("Fatorial = " + fatorial);
}

