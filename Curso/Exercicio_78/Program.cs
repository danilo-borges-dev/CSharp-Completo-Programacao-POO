using Exercicio_78.Models.Enums;
using Exercicio_78.Models;
using System.Globalization;

string nome;
string email;
int status =  new int();
DateTime dataAniversario = new DateTime();
DateTime momento = DateTime.Now;
StatusPedido statusPedido = new StatusPedido();
int qtdProdutos = new int();
string nomeProduto;
double valorProduto = new double();
int quantidadeProduto = new int();

Pedido pedido;

Console.WriteLine("Entre com as informações do Cliente: ");
Console.Write("Nome: ");
nome = Console.ReadLine();
Console.Write("E-mail: ");
email = Console.ReadLine();
Console.Write("Data de Aniversário (DD/MM/YYYY): ");
dataAniversario = DateTime.Parse(Console.ReadLine());
Console.Write("Estatus do pedido ( 1 - Aguardo Pagamento | 2 - Processando | 3 - Pagamento Aprovado | 4 - Envaido ): ");
status = int.Parse(Console.ReadLine());

if (status == 1)
{
    Enum.TryParse("Aguardando_Pagamento", out statusPedido);
}
else if (status == 2)
{
    Enum.TryParse("Processando", out statusPedido);
}
else if(status == 3)
{
    Enum.TryParse("Pagamento_Aprovado", out statusPedido);
}
else
{
    Enum.TryParse("Enviado", out statusPedido);
}

pedido = new(momento, statusPedido, new Cliente(nome, email, dataAniversario));

Console.Write("\nQuantos Prdotudos tem neste Pedido? ");
qtdProdutos = int.Parse(Console.ReadLine());
for (int i = 0; i < qtdProdutos; i++)
{
    Console.WriteLine($"\nDados do {i + 1} Produto: ");
    Console.Write("Nome do Produto: ");
    nomeProduto = Console.ReadLine();
    Console.Write("Valor $ ");
    valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantidade: ");
    quantidadeProduto = int.Parse(Console.ReadLine());

    pedido.AddPedidoItem(new PedidoItem(quantidadeProduto, valorProduto, new Produto(nomeProduto, valorProduto)));
}

Console.WriteLine("\nSUMÁRIO DO PEDIDO:");
Console.WriteLine(pedido);