using System.Globalization;

namespace Exercicio_15
{
    internal class ContaCorrente
    {
        public readonly int NumeroConta;
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; } = new double();

        public ContaCorrente(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = 0;
        }
        public ContaCorrente(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public void DepositarValorEmContaCorrente(double valor)
        {
            if (valor > 0)
            {
                Saldo = valor;
                Console.WriteLine($"\nValor R${valor.ToString("F2", CultureInfo.InvariantCulture)} Depositado com Sucesso!\n");
            }
            throw new ArgumentOutOfRangeException();
        }

        public void RealizarSaqueEmContaCorrente(double valor)
        {
            Saldo -= (valor + 5.00);
            Console.WriteLine($"\nSaque de R${valor.ToString("F2", CultureInfo.InvariantCulture)} Realizado com Sucesso!\n");
            Console.WriteLine($"\nSaldo da Conta ");
        }

        public override string ToString()
        {
            return $"\nDados da conta atualizados:\n" +
                $"Conta {NumeroConta} Titular: {NomeTitular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
