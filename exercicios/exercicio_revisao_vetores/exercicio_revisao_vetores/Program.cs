using exercicio_revisao_vetores;

Aluguel[] quartos = new Aluguel[10];

Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Rent #" + i);

    Console.Write("Name: ");
    string nome = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Room: ");
    int quarto = int.Parse(Console.ReadLine());

    quartos[quarto] = new Aluguel(nome, email);

    Console.WriteLine();
}

Console.WriteLine("Busy rooms:");
for(int i = 0; i < 10; i++)
{
    if (quartos[i] != null)
    {
        Console.WriteLine(i + ": " + quartos[i]);
    }
}
