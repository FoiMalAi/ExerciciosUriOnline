using System;

namespace Exercicio1014
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dist;
            double comb, consumo;

            dist = int.Parse(Console.ReadLine());
            comb = double.Parse(Console.ReadLine());

            consumo = dist / comb;

            Console.WriteLine(consumo.ToString("F3") + " km/l");  

        }
    }
}
