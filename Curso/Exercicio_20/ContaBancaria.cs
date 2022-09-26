using System.Globalization;

namespace Exercicio_20
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }
        public ContaBancaria(int numero, string titular, double desposito) : this (numero, titular)
        {
            Deposito(desposito);
        }
        public override string ToString()
        {
            return $"Conta {Numero}, Titular {Titular}, Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= (quantia + 5.0);
        }
    }
}
