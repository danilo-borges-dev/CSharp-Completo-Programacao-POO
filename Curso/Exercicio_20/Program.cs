using Exercicio_20;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new(numero, titular);
}

Console.WriteLine($"\nDados da conta: \n{conta}");
