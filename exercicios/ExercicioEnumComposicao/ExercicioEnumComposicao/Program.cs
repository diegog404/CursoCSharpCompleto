using ExercicioEnumComposicao.Entities;
using ExercicioEnumComposicao.Enums;
using System.Globalization;
using System.Xml.Linq;

Console.WriteLine("Enter client data:");
Console.WriteLine();

Console.WriteLine("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime date = DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, date);
Console.WriteLine();

Console.WriteLine("Enter order data:");

Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.WriteLine();

Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Enter #{i} item data:");
    Console.WriteLine();

    Console.Write("Product name: ");
    string prodName = Console.ReadLine();

    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product prod = new Product(prodName, price);
    OrderItem orderItem = new OrderItem(quantity, price, prod);
    
    order.AddItem(orderItem);
}

Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);
Console.WriteLine("Total price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));



