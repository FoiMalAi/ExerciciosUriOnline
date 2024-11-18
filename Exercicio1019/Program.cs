namespace Exercicio1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, horas, resto, min, seg;
            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            min = resto / 60;
            seg = resto % 60;
            

            Console.WriteLine(horas + ":" + min + ":" + seg);
        }
    }
}
