using Exercicio_41;
using System.Globalization;

int numeroConta = new int();
string titularConta;
double valor = new double();
char escolhaOpacao = new char();

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre com o Titular da conta: ");
titularConta = Console.ReadLine();
Console.Write("Haverá Depósito Inicial? (S/N) ");
escolhaOpacao = char.Parse(Console.ReadLine());


if (escolhaOpacao == 's' || escolhaOpacao == 'S')
{
    Console.Write("Entre com o valor para Depósito Inicial $ ");
    valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new(numeroConta, titularConta, valor);
}
else
{
    conta = new(numeroConta, titularConta);
}

Console.WriteLine($"\nDados da Conta: ");
Console.WriteLine($"Conta {conta.NumeroConta}, Titular {conta.Titular}, Saldo $ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("\nEntre comm o valor para Depósito: $ ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(valor);
Console.WriteLine(conta);

Console.Write("\nEntre com o valor para Saque: $ ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(valor);
Console.WriteLine(conta);