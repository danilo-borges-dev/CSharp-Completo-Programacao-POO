using Exercicio_115.Entities;
using Exercicio_115.Exceptions;
using System.Globalization;

int number = new int();
string holder;
double initialBalance = new double();
double withdrawLimit = new double();
double withdraw = new double();

Account account;

try
{
    Console.WriteLine("Enter account data: ");
    Console.Write("Number: ");
    number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    holder = Console.ReadLine();
    Console.Write("Initial balance $ ");
    initialBalance = double.Parse(Console.ReadLine());
    Console.Write("Withdraw limit $ ");
    withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account = new(number, holder, initialBalance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw $ ");
    withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(withdraw);
    Console.WriteLine($"New balance $ {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (InvalidAmmountException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Block Finally.");
}


