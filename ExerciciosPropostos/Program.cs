using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double area,raio, n = 3.14159;


            raio = double.Parse(Console.ReadLine());

            area = n * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4"));    

        }
    }
}