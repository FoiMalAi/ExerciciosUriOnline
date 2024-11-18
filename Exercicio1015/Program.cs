using System;
namespace Exercicio1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] v = Console.ReadLine().Split(' ');
            x1 = double.Parse(v[0]);
            y1 = double.Parse(v[1]);

            v = Console.ReadLine().Split(' ');
            x2 = double.Parse(v[0]);
            y2 = double.Parse(v[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
