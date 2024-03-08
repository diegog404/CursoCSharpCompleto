using ExercicioHerancaPolimorfismo.Entities;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine();

    Console.WriteLine($"Product #{i} data:");
    Console.WriteLine();

    Console.Write("Common, used or imported (c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(resp == 'c')
    {
        products.Add(new Product(name, price));
    }
    else if (resp == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        products.Add(new ImportedProduct(customFee, name, price));
    }
    else
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manuDate = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(manuDate, name, price));
    }    
}
Console.WriteLine();

Console.WriteLine("PRICE TAGS");
Console.WriteLine();

foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}

