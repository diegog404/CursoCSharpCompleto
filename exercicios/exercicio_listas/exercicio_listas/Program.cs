using exercicio_listas;
using System.Collections.Generic;
using System.Globalization;

Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

List<Employee> dados = new List<Employee>(n);

for(int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee: #" + i);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    dados.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase: ");
int searchId = int.Parse(Console.ReadLine());
Console.WriteLine();

Employee incSalary = dados.Find(x => x.Id == searchId);

if(incSalary != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    incSalary.IncreseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exists!");
}
Console.WriteLine();

Console.WriteLine("Updated list of employees:");
foreach(Employee obj in dados)
{
    Console.WriteLine(obj);
}

