//Áreas

using System;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] area = Console.ReadLine().Split(' ');
            A = double.Parse(area[0]);
            B = double.Parse(area[1]);
            C = double.Parse(area[2]);

            /*
            Estes vetores são usados apenas quando qeuero ler os meus valores
            separados por espasços
            */

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }
}