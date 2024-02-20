using ExercicioClasses02;
using System.Globalization;

Funcionario a, b;

a = new Funcionario();
b = new Funcionario();

Console.WriteLine("Insira os dados do primeiro funcionário:");

Console.Write("Nome: ");
a.Nome = Console.ReadLine();

Console.Write("Salário: ");
a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Console.WriteLine("Insira os dados do segundo funcionário:");

Console.Write("Nome: ");
b.Nome = Console.ReadLine();

Console.Write("Salário: ");
b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

double salarioMedio = (a.Salario + b.Salario) / 2.0;
Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));