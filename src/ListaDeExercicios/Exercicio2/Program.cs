// See https://aka.ms/new-console-template for more information
//2. **Converter a temperatura de graus Fahrenheit para graus Celsius.**
//- Exemplo de entrada: Temperatura em Fahrenheit = 68
//- Fórmula: Celsius = (Fahrenheit - 32) * 5/9
//- Exemplo de saída: A temperatura em Celsius é 20 °C.]

Double grauC, grauF;

Console.WriteLine("Graus F:");
grauF = Double.Parse(Console.ReadLine());
grauC = (grauF - 32) * 5 / 9;
Console.WriteLine("Graus C = " + grauC);  