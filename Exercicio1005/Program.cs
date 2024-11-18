using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double MEDIA, PESO, A, B;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            PESO = (A * 3.5) + (B * 7.5);
            MEDIA = (PESO / 11);

            //Outra forma de executar o cauculo:
            //MEDIA = ((A * 3.5) + (B * 7.5)) / 11

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

        }
    }
}