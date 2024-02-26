using exercicio_listas;
using System.Collections.Generic;
using System.Globalization;

Console.Write("Quantos empregados serão contratados? ");
int N = int.Parse(Console.ReadLine());

List<Employee> employees = new List<Employee>();

for(int i = 1; i <= N; i++)
{
    Console.WriteLine();

    Console.WriteLine($"Employee #{i}");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string nome = Console.ReadLine();

    Console.Write("Salario: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    employees.Add(new Employee(id, nome, salario));
}
Console.WriteLine();

Console.Write("Entre com id do empregado que téra o salário aumentado: ");
int idIndex = int.Parse(Console.ReadLine());

Employee emp = employees.Find(x => x.Id == idIndex);

if(emp != null)
{
    Console.Write("Entre com a porcentagem: ");
    double pcr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.AumentarSalario(pcr);
}
else
{
    Console.WriteLine("Esse Id não existe.");
}
Console.WriteLine();

Console.WriteLine("Lista de empregados atualizada:");
foreach(Employee obj in employees)
{
    Console.WriteLine(obj);
}

