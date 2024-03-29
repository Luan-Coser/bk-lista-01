// See https://aka.ms/new-console-template for more information
//3. * *Calcular o consumo de combustível por quilômetro.**
//   - Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
//   - Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
//   - Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.

float inicial, final, consumo, resposta;

Console.WriteLine("Km Inicial: ");
inicial = float.Parse(Console.ReadLine());

Console.WriteLine("Km Final:");
final = float.Parse(Console.ReadLine());

Console.WriteLine("Consumo L:");
consumo = float.Parse(Console.ReadLine());

resposta = consumo  / (final - inicial );
Console.WriteLine("Resposta:"+resposta);

