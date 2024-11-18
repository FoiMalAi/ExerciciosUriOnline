//Volume de uma esfera

double R, volume, pi = 3.14159;

R = double.Parse(Console.ReadLine());

volume = (4.0 / 3.0) * pi * R * R * R;

Console.WriteLine("VOLUME = " + volume.ToString("F3"));