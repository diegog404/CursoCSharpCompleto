using ExercicioHerancaPolimorfismo02.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

List<TaxPayer> taxPayers= new List<TaxPayer>();

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or Company (i/c)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(resp == 'i')
    {
        Console.Write("Health expeditures: ");
        double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayers.Add(new Individual(healthEx, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employeeNumber = int.Parse(Console.ReadLine());

        taxPayers.Add(new Company(employeeNumber, name, anualIncome));
    }

    Console.WriteLine();
}

Console.WriteLine("TAXES PAID:");
double sum = 0;

foreach(TaxPayer tp in taxPayers)
{
    Console.WriteLine(tp.Name + ": $ " + tp.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
    sum = sum + tp.TaxesPaid();
}
Console.WriteLine();

Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));




