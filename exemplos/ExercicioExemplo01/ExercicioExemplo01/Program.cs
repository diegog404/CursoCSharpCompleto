using ExercicioExemplo01;
using System.Globalization;

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo x:");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Entre com as medidas do triangulo y:");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}


