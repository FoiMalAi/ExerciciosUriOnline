using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int SOMA, A,B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine()); 
            
            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);

        }
    }
}