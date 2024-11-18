//Salário com Bonus

string name;
double salary, tvendas, total;

name = Console.ReadLine();
salary = double.Parse(Console.ReadLine());  
tvendas = double.Parse(Console.ReadLine());

total = tvendas * 15 / 100 + salary;

Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));


