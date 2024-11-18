namespace Exercicio2018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, X, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            X= resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 1;
            X = resto / nota;
            Console.WriteLine(X + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

        }
    }
}
