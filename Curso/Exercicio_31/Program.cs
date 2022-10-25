using Exercicio_31;
using System.Globalization;

int numeroConta = new int();
string nomeTitular;
double valor = new double();
char haveriaDepositoInicial = new char();
ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre com o nome do titular da conta: ");
nomeTitular = Console.ReadLine();
Console.Write("Haverá depósito inicial? (s/n) ");
haveriaDepositoInicial = char.Parse(Console.ReadLine());

if (haveriaDepositoInicial == 's' || haveriaDepositoInicial == 'S')
{
    Console.Write("Entre com o valor do depósito inical $ ");
    valor = double.Parse(Console.ReadLine());

    conta = new(numeroConta, nomeTitular, valor);    
}
else
{
    conta = new(numeroConta, nomeTitular);
}

Console.WriteLine("\nDados da conta: ");
Console.WriteLine($"Conta: {conta.NumetoConta}, Titular: {conta.NomeTitular}, Saldo $ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nEntre com o valor para depósito $ ");
valor = double.Parse(Console.ReadLine());
conta.Depositar(valor);
Console.WriteLine(conta);

Console.Write("\nEntre com o valor para saque $ ");
valor = double.Parse(Console.ReadLine());
conta.Sacar(valor);
Console.WriteLine(conta);
