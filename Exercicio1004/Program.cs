﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int PROD, A, B;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);

        }
    }
}