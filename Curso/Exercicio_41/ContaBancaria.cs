using System.Globalization;

namespace Exercicio_41
{
    internal class ContaBancaria
    {
        public readonly int NumeroConta;
        public string Titular { get; private set; }
        public double Saldo { get; private set; } = new double();

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            Depositar(saldo);
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Operação de Depósito Realizada com Sucesso. Saldo Atual $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Operação Inválida. Saldo Atual $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= (valor + 5.0);
                Console.WriteLine($"Operação de Saque Realizada com Sucesso. Saldo Atual $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Operação Inválida. Saldo Atual $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public override string ToString()
        {
            return $"\nDados da conta Atualizados: " +
                $"\nConta {NumeroConta}, Titular {Titular}, Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
