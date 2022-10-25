using System.Globalization;

namespace Exercicio_31
{
    internal class ContaBancaria
    {
        public readonly int NumetoConta;
        public string NomeTitular { get; private set; }
        public double Saldo { get; private set; } = new double();

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumetoConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Depositar(saldo);
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor inválido para Depósito.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo && valor > 0)
            {
                Saldo -= (valor + 5.0);
                Console.WriteLine("Saque realizado com Sucesso!");
            }
            else
            {
                Console.WriteLine("Valor inválido para Saque.");
            }
        }

        public override string ToString()
        {
            return $"\nDados da conta atualizados:" +
                $"\nConta: {NumetoConta}, Titular: {NomeTitular}, Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
