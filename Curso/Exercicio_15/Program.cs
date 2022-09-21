using Exercicio_15;
using System.Globalization;

int numeroConta = new int();
string nomeTitularConta;
char teraOuNaoDepositoInicial = new char();
double valorParaDepositoInicial = new double();
ContaCorrente conta = null;

Console.Write("Entre com o número da conta: ");
numeroConta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
nomeTitularConta = Console.ReadLine();


do
{
    Console.Write("Haverá depósito inicial (s/n)?: ");
    teraOuNaoDepositoInicial = char.Parse(Console.ReadLine());
} while (!(teraOuNaoDepositoInicial == 's' || teraOuNaoDepositoInicial == 'n')); 
// Se o valor da variável for igual a s ou igual a n eu inverto o valor e dou sequência no código,
// e ambos forem diferentes resultando em true eu inverto o valor para false e continua no bloco do while

if (teraOuNaoDepositoInicial.ToString().ToLower() == "s")
{
    Console.Write("Entre um valor para depósito: ");
    valorParaDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    ContaCorrente novaContaCorrenteSemSaldoInicial = new(numeroConta, nomeTitularConta, valorParaDepositoInicial);
    Console.WriteLine(novaContaCorrenteSemSaldoInicial);
    conta = novaContaCorrenteSemSaldoInicial;
    
    OperarConta();
}
else
{
    ContaCorrente novaContaCorrenteComSaldoInicial = new(numeroConta, nomeTitularConta);
    Console.WriteLine(novaContaCorrenteComSaldoInicial);
    conta = novaContaCorrenteComSaldoInicial;

    OperarConta();
}

void OperarConta()
{
    Console.Write("\nEntre com um valor para depósito: ");
    double valorParaDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine(conta);

    Console.Write("\nEntre com um valor para saque: ");
    double valorParaSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine(conta);
}

