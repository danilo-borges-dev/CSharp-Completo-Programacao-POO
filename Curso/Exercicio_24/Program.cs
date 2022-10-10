using Exercicio_24;
using System.Globalization;

int numeroConta = new int();
string nomeTitular;
char opcao = new char();
double saldoInicial = new double();

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre com o nome do Titular da conta: ");
nomeTitular = Console.ReadLine();
Console.Write("Haverá depósito inicial? (s/n) ");
opcao = char.Parse(Console.ReadLine());

if (opcao == 's' || opcao == 'S')
{
    Console.Write("Entre com o valor do Saldo inicial $ ");
    saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new(nomeTitular, numeroConta, saldoInicial);
}
else
{
    conta = new(nomeTitular, numeroConta);
}

Console.WriteLine("\nDados da conta: ");
Console.WriteLine($"Conta {conta._numeroConta} Titular {conta._nomeTitular}, Saldo $ {conta._saldo.ToString("F2", CultureInfo.InvariantCulture)}");