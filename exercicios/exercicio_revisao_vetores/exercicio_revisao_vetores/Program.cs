using exercicio_revisao_vetores;

Aluguel[] vect = new Aluguel[10];

Console.Write("Quantos quartos serão alugados? ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();

for(int i = 1; i <= N; i++)
{
    Console.WriteLine("Rent #" + i);

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());

    vect[quarto] = new Aluguel(nome, email, quarto);
    Console.WriteLine();
}

Console.WriteLine("Quartos ocupados:");

for (int i = 0; i < 10; i++)
{
    if (vect[i] != null)
    {
        Console.WriteLine(vect[i]);
    }
}


