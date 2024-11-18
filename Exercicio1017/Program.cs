
using System;
namespace Exercicio1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            double quantidade, tempo, velocidade, distancia; ;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            quantidade = distancia / 12;

            Console.WriteLine(quantidade.ToString("F3"));

        }
    }
}
