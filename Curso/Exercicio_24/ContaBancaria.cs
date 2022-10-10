using System.Globalization;

namespace Exercicio_24
{
    internal class ContaBancaria
    {
        public readonly string _nomeTitular;
        public int _numeroConta { get; private set; } = new int();
        public double _saldo { get; private set; } = new double();

        public ContaBancaria(string nomeTitular, int numeroConta) 
        {
            _nomeTitular = nomeTitular;
            _numeroConta = numeroConta;
        }

        public ContaBancaria(string nomeTitular, int numeroConta, double saldoInicial) : this (nomeTitular, numeroConta)
        {
            _saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                Console.WriteLine("Operação de Depósito realizado com Sucesso.");
            }
            Console.WriteLine("Operação não Permitida, tente novamente.");
        }

        public void Sacar(double valor)
        {
            if (valor <= _saldo)
            {
                _saldo -= (valor + 5.0);
                Console.WriteLine("Operação de Saque realizado com Sucesso.");
            }
            Console.WriteLine($"Operação não permitida. Valor para Saque $ {_saldo.ToString("F", CultureInfo.InvariantCulture)}");
        }
    }
}
