using ExercicioHerancaPolimorfismo.Entities;
using System.Globalization;

List<Product> prod = new List<Product>();

Console.Write("Enter the number of products: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(resp == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        prod.Add(new ImportedProduct(name, price, customFee));
    }
    else if(resp == 'c')
    {
        prod.Add(new Product(name, price));
    }
    else
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime md = DateTime.Parse(Console.ReadLine());

        prod.Add(new UsedProduct(name, price, md));
    }

    Console.WriteLine();
}

Console.WriteLine("PRICE TAGS:");

foreach(Product product in prod)
{
    Console.WriteLine(product.PriceTag());
}

