using Exercicio_91.Models;
using Exercicio_91.Exceptions;
using System.Globalization;

int numberAccount = new int();
string holderAccount;
double initialBalance = new double();
double withdrawLimit = new double();
double value = new double();

Console.WriteLine("Enter account data");
Console.Write("Number: ");
numberAccount = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
holderAccount = Console.ReadLine();
Console.Write("Initial balance: ");
initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
Console.Write("Withdraw limit: ");
withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    Account account = new(numberAccount, holderAccount, initialBalance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw: ");
    value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account.Withdraw(value);

    Console.WriteLine($"New Balance $ {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (AmountInvalidException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

