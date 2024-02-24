using exercicio_construtores_encapsulamento_properties;
using System.Globalization;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre com o titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Haverá depósito inicial s/n ? ");
char opcao = char.Parse(Console.ReadLine());

ContaBancaria cb;

if(opcao == 's')
{
    Console.Write("Entre com o valor do saldo inicial: ");
    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    cb = new ContaBancaria(numero, nome, valor);


}
else
{
    cb = new ContaBancaria(numero, nome);
}
Console.WriteLine();

Console.WriteLine("Dados da conta");
Console.WriteLine(cb);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cb.Deposito(qtd);
Console.WriteLine();

Console.WriteLine("Dados da conta atualizados");
Console.WriteLine(cb);
Console.WriteLine();

Console.Write("Entre com um valor para saque: ");
qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
cb.Saque(qtd);
Console.WriteLine();

Console.WriteLine("Dados da conta atualizados");
Console.WriteLine(cb);
