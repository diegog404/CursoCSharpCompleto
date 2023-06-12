using HerancaExemplo2.Entities;
using System.Collections.Generic;
using System.Globalization;

List<Employee> emp = new List<Employee>();

Console.Write("Enter the number of employees: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N;)
{
    Console.WriteLine($"Employee {i}# data:");

    Console.Write("Outsourced (y/n)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.Write("Value per hours: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(resp == 'y')
    {
        Console.Write("Additional charge:  ");
        double ac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, ac));
    }
    else
    {
        emp.Add(new Employee(name, hours, valuePerHour));
    }
    Console.WriteLine();
}

Console.WriteLine("PAYMENTS:");

foreach(Employee employee in emp)
{
    Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
}