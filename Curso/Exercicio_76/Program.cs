using Exercicio_76.Models.Exceptions;
using Exercicio_76.Models;
using System.Globalization;

int numeroConta = new int();
string nomeCliente;
double saldoInicial = new double();
double limiteParaSaque = new double();
double valorParaSaque = new double();

try
{
    ContaBancaria conta;

    Console.WriteLine("Entre com os dados da conta: ");
    Console.Write("Número: ");
    numeroConta = int.Parse(Console.ReadLine());
    Console.Write("Titular: ");
    nomeCliente = Console.ReadLine();
    Console.Write("Saldo inicial: $ ");
    saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Limite para Saque: $ ");
    limiteParaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new(numeroConta, nomeCliente, saldoInicial, limiteParaSaque);

    Console.Write("\nInforme o valor para saque: $ ");
    valorParaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta.Sacar(valorParaSaque);
    Console.Write($"Saldo atualizado: $ {conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (ValorDinheiroInvalidoException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex) 
{
    Console.WriteLine(ex.Message);
}
