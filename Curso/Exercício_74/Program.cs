using Exercício_74.Models;
using Exercício_74.Models.Excetions;
using System.Globalization;

string titularConta;
int numeroConta = new int();
double saldoInicial = new double();
double limiteParaSaque = new double();
double valorSaque = new double();

ContaBancaria conta;

try
{
    Console.WriteLine("Entre com os Dados da Conta:");
    Console.Write("Número: ");
    numeroConta = int.Parse(Console.ReadLine());
    Console.Write("Titular: ");
    titularConta = Console.ReadLine();
    Console.Write("Saldo inicial $ ");
    saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Limite de saque $ ");
    limiteParaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new(numeroConta, titularConta, saldoInicial, limiteParaSaque);

    Console.Write("\nInforme o valor para saque $ ");
    valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta.Sacar(valorSaque);

    Console.WriteLine($"Novo Saldo $ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (InvalidValueException ex)
{
    Console.WriteLine(ex.Message);
}


