using ExercicioClassesMetodos02;
using System.Globalization;

Funcionario f = new Funcionario();

Console.Write("Nome: ");
f.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Funcionário: " + f);
Console.WriteLine();

Console.Write("Insira a porcentagem para aumentar o salário: ");
double pcr = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(pcr);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + f);

