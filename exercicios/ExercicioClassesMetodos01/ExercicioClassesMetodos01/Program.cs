using ExercicioClassesMetodos01;
using System.Globalization;

Retangulo r = new Retangulo();

Console.WriteLine("Insira a largura e altura do retangulo:");
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
