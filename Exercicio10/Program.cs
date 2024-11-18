//Cauculo Simples

using System.Security.Cryptography;

int cod1, cod2, qtd1, qtd2;
double valor1, valor2, total;

string[] valores = Console.ReadLine().Split(' ');
cod1 = int.Parse(valores[0]);
qtd1 = int.Parse(valores[1]);
valor1 = double.Parse(valores[2]);

valores = Console.ReadLine().Split(' ');
cod2 = int.Parse(valores[0]);
qtd2 = int.Parse(valores[1]);
valor2 = double.Parse(valores[2]);

total = valor1 * qtd1 + valor2 * qtd2;

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));






