namespace Exercicio1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dia, resto;

            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            resto = idade % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
