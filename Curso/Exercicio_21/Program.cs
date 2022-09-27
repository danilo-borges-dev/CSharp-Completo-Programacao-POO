using Exercicio_21;
using System.Globalization;

string titular;
int numeroConta = new int();
char opcao = new char();
double valor = new double();

ContaBancaria conta;

Console.Write("Entre o número da conta: ");
numeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Entre o nome do titular: ");
titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
opcao = char.Parse(Console.ReadLine());

if (opcao != 'n' && opcao != 'N')
{
    Console.Write("Entre o valor de saldo inicial: ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new(numeroConta, titular, valor);
}
else
{
    conta = new(numeroConta, titular);
}

Console.WriteLine("\nDados da conta:");
Console.WriteLine($"Conta {conta.NumeroConta}, Titular: {conta.Titular}, Saldo $ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nEntre com o valor para depósito: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(valor);
Console.WriteLine(conta);


Console.Write("\nEntre com o valor para saque: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(valor);
Console.WriteLine(conta);