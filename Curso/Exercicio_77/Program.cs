using Exercicio_77.Models;
using System.Globalization;

int qtdProdutos = new int();
char opcao = new char();
string nomeProduto;
double precoProduto = new double();
double valorImportacao = new double();
DateTime dataDeFabricao = new DateTime();

List<Produto> listaDeProdutos = new List<Produto>();

Console.Write("Informe o número de Produtos: ");
qtdProdutos = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdProdutos; i++)
{
    Console.WriteLine($"\nProduto #{i + 1}: ");
    Console.Write("Comum, usado ou importado? (c/u/i) ");
    opcao = char.Parse(Console.ReadLine());

    Console.Write("Nome: ");
    nomeProduto = Console.ReadLine();
    Console.Write("Preço: $ ");
    precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (opcao == 'i' || opcao == 'I')
    {
        Console.Write("Valor de importação: $ ");
        valorImportacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listaDeProdutos.Add(new ProdutoImportado(valorImportacao, nomeProduto, precoProduto));
        continue;
    }

    if (opcao == 'u' || opcao == 'U')
    {
        Console.Write("Data de Fabricação: (DD/MM/YYYY) ");
        dataDeFabricao = DateTime.Parse(Console.ReadLine());
        listaDeProdutos.Add(new ProdutoUsado(dataDeFabricao, nomeProduto, precoProduto));
        continue;
    }

    listaDeProdutos.Add(new Produto(nomeProduto, precoProduto));
}

foreach (Produto produto in listaDeProdutos)
{
    Console.WriteLine(produto.PrecoTag());
}