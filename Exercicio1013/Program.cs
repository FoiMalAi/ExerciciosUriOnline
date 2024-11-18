using System;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, maiorAB, maior;

            string[] valores = Console.ReadLine().Split(' ');
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maiorAB = (a + b + Math.Abs(a - b)) / 2;  //abs nesse caso é usado para o valor absoluto
            maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;


            /*Outra forma simplificada de achar o maior valor:
             - maior = Math.Max(a, Math.Max(b, c));*/

            Console.WriteLine(maior + " eh o maior");
        }
    }
}