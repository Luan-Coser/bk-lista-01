namespace Exercicio01
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/
            Double altura, largura, comprimento, resultado;

            Console.WriteLine("Altura:");
            altura = Double.Parse(Console.ReadLine()); 
            
            Console.WriteLine("Largura:");
            largura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Comprimento:");
            comprimento = Double.Parse(Console.ReadLine());

            resultado = altura * largura * comprimento;

            Console.WriteLine($"O resultado é {resultado}");
        } 
    }
}
