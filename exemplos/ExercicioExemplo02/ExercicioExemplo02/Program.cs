using ExercicioExemplo02;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Insira os dados do produto:");
Console.WriteLine();

Console.Write("Nome: ");
p.Nome = Console.ReadLine();

Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Dados do produto: " + p);
Console.WriteLine();

Console.Write("Insira o número de produtos a ser adicionado ao estoque: ");
int qtd = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qtd);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine();

Console.Write("Insira o número de produtos a ser removido do estoque: ");
qtd = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtd);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine();