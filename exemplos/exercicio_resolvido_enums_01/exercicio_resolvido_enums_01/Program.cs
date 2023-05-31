using System;
using exercicio_resolvido_enums_01.Entities;
using exercicio_resolvido_enums_01.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();

Console.WriteLine("Enter worker data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);


Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");

    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());

    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}