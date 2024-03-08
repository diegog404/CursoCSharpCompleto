using ExercicioHerancaPolimorfismo02.Entities;
using System.Globalization;

List<TaxPayer> payers = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine();

    Console.WriteLine($"Tax payer #{i} data:");
    Console.WriteLine();

    Console.Write("Individual or company (i/c)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(resp == 'i')
    {
        Console.Write("Health expeditures: ");
        double healthEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        payers.Add(new Individual(healthEx, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int empCount = int.Parse(Console.ReadLine());

        payers.Add(new Company(empCount, name, anualIncome));
    }
}
Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double total = 0;

foreach(TaxPayer payer in payers)
{
    total = total + payer.Tax();
    Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
}
Console.WriteLine();

Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));




