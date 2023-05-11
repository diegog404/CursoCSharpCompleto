﻿using ExercicioClassesMetodos02;
using System.Globalization;

Funcionario dados = new Funcionario();

Console.Write("Nome: ");
dados.Nome = Console.ReadLine();

Console.Write("Salário Bruto: ");
dados.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("Funcionário: " + dados);
Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário: ");
double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
dados.AumentarSalario(pct);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + dados);