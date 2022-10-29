using Revisao_Vetores_02;
using System.Globalization;

int qtdProdutos = new int();
string nomeProd;
double valorProd = new double();
double valorMedio = new double();
Produto[] listaDeProdutos;

Console.Write("Informa a quantidade de produtos que ira cadastrar: ");
qtdProdutos = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
listaDeProdutos = new Produto[qtdProdutos];

for (int i = 0; i < qtdProdutos; i++)
{
    Console.Write($"\nNome do {i + 1}º Produto: ");
    nomeProd = Console.ReadLine();
    Console.Write($"Valor: $ ");
    valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    // Não precisa Nomear o Objeto que será Instanciado (Variável),
    // porque o Indíce do Vetor irá Armazenar o Endereço do Objeto em Memória (Que é o importante).
    listaDeProdutos[i] = new Produto(nomeProd, valorProd);  
}

for (int i = 0; i < qtdProdutos; i++)
{
    valorMedio += listaDeProdutos[i].Valor;
}

Console.WriteLine($"\nValor médio dos Produtos: $ {(valorMedio / qtdProdutos).ToString("F2", CultureInfo.InvariantCulture)}");