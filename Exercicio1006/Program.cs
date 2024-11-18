double MEDIA, A, B, C;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
C = double.Parse(Console.ReadLine());


MEDIA = ((A * 2 + B * 3 + C * 5)) / 10;

Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));