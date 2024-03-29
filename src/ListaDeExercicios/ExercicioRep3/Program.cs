// See https://aka.ms/new-console-template for more information

//3. * *Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.**
//   - Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
//   - Fórmula: IMC = Peso / (Altura ^ 2)
//   - Exemplo de saída: IMC = 22.86(Peso normal).

double peso, altura, imc;


Console.Write("Peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Altura: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (18.5 > imc && imc < 24.9)
{
    Console.Write($"IMC = {imc}(Peso normal). ");

}else if (25.0 > imc && imc < 29.9)
{
    Console.Write($"IMC = {imc}(Sobrepeso). ");

}else if (30.0 > imc && imc < 39.9)
{
    Console.Write($"IMC = {imc}(Obesidade). ");

}else if (40.0 < imc)
{
    Console.Write($"IMC = {imc}(Obesidade Grave). ");

}

