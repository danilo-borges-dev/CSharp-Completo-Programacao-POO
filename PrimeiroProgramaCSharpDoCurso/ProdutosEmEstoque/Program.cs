using ProdutosEmEstoque;
using System.Globalization;

Produto p = new();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.QtdEstoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double valor = p.QtdEstoque * p.Preco;

Console.WriteLine($"\nDados do produto: {p.Nome}, {p.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {p.QtdEstoque} unidades, Total: ${valor.ToString("F2", CultureInfo.InvariantCulture)}");


Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
int n = int.Parse(Console.ReadLine());
p.AdicionarNoEstoque(n);

Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
n = int.Parse(Console.ReadLine());
p.RemoverDoEstoque(n);
Console.WriteLine();