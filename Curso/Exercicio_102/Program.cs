using Exercicio_102.Entities;
using Exercicio_102.Exceptions;
using System.Globalization;

int number = new int();
string holder;
double balance = new double();
var withdrawLimit = new double();
double value = new double();

try
{
    Account account;

    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    holder = Console.ReadLine();
    Console.Write("Initial Balance $ ");
    balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit $ ");
    withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account = new(number, holder, balance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw: ");
    value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.WithDraw(value);
    Console.WriteLine($"New balance {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.Write("Deposit value $ ");
    value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Deposit(value);
    Console.WriteLine($"New balance {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (InvalidValueException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

