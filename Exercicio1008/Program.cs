


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int NF, HT;
            double VH, SALARIO;

            NF = int.Parse(Console.ReadLine());
            HT = int.Parse(Console.ReadLine());
            VH = double.Parse(Console.ReadLine());

            SALARIO = HT * VH;

            Console.WriteLine("NUMBER = " + NF);
            Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2"));

        }
    }
}