// See https://aka.ms/new-console-template for more information

//   4. * *Calcular o salário total de um vendedor.**
//   - Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão (5 % sobre as vendas)
//   - Fórmula: Salário total = Salário base + (Total de vendas * Comissão)
//   - Exemplo de saída: O salário total do vendedor é R$ 1750.

Double salarioBase = 1500, salarioTotal, vendas = 5000;

salarioTotal = salarioBase + (vendas * 0.05);
Console.WriteLine("Salario = "+salarioTotal);
