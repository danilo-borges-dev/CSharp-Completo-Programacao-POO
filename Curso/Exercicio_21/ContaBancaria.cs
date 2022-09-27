using System.Globalization;

namespace Exercicio_21
{
    internal class ContaBancaria
    {
        public readonly int NumeroConta;
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Deposito(saldo);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return $"\nDados da conta atualizados:" +
                $"\nConta {NumeroConta}, Titular {Titular}, Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
