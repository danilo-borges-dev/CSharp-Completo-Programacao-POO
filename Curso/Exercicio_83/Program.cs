using Exercicio_83.Models;
using Exercicio_83.Models.Exceptions;
using System.Globalization;

int numberAccount = new int();
string holder;
double initialBalance = new double();
double withdrawLimit = new double();
double withdraw = new double();



try
{
    ContaBancaria conta;

    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    numberAccount = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    holder = Console.ReadLine();
    Console.Write("Initial Balance: $ ");
    initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: $ ");
    withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new ContaBancaria(numberAccount, holder, initialBalance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw: $ ");
    withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta.Withdraw(withdraw);
    Console.Write("New Balance: $ " + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (NegativeValueExcetion ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Exceção não tratada. " + ex.Message);
}
