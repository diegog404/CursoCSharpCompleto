using ExercicioClasses01;

Pessoa a, b;

a = new Pessoa();
b = new Pessoa();

Console.WriteLine("Insira os dados da primeira pessoa:");

Console.Write("Nome: ");
a.Nome = Console.ReadLine();
Console.Write("Idade: ");
a.Idade = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Insira os dados da segunda pessoa:");

Console.Write("Nome: ");
b.Nome = Console.ReadLine();
Console.Write("Idade: ");
b.Idade = int.Parse(Console.ReadLine());

Console.WriteLine();

if(a.Idade > b.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + a.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + b.Nome);
}

