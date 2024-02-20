using ContaBancariaExceptions.Entities;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data:");
    Console.WriteLine();

    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());

    Console.Write("Holder: ");
    string holder = Console.ReadLine();

    Console.Write("Initial balance: ");
    double ib = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Withdraw limit: ");
    double wl = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, ib, wl);
    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(amount);
    Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
