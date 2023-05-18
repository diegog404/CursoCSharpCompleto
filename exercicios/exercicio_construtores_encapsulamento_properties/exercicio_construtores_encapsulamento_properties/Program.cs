using exercicio_construtores_encapsulamento_properties;
using System.Globalization;

ContaBancaria dados;

Console.Write("Entre o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nome = Console.ReadLine();

Console.Write("Haverá depósito inicial(s/n)? ");
char resposta = char.Parse(Console.ReadLine());

if(resposta == 's')
{
    Console.Write("Entre o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    dados = new ContaBancaria(numero, nome, depositoInicial);
}
else
{
    dados = new ContaBancaria(numero, nome);
}
Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(dados);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
dados.Deposito(qtd);
Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(dados);
Console.WriteLine();

Console.Write("Entre um valor para saque: ");
qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
dados.Saque(qtd);
Console.WriteLine();

Console.WriteLine("Dados da conta:");
Console.WriteLine(dados);
Console.WriteLine();