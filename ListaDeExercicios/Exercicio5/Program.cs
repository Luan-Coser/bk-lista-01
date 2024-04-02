// See https://aka.ms/new-console-template for more information

//5. * *Calcular a média ponderada de duas provas realizadas por um aluno.**
//   - Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
//   - Fórmula: Média ponderada = (Nota da primeira prova * Peso da primeira prova) + (Nota da segunda prova * Peso da segunda prova)
//   - Exemplo de saída: A média ponderada do aluno é 7.6.

int nota1 = 7, nota2 = 8;
double peso1 = 0.4, peso2 = 0.6, mediaP;

mediaP = (nota1 * peso1) + (nota2 * peso2);
Console.WriteLine("Media:"+mediaP);
