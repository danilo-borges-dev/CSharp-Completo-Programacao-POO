using Exercício_74.Models.Excetions;

namespace Exercício_74.Models
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; } = new int();
        public string Titular { get; private set; }
        public double Saldo { get; private set; } = new double();
        public double LimiteDeSaque { get; private set; } = new double();

        public ContaBancaria(int numero, string titular, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Titular = titular;
            Depositar(saldo);
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new InvalidValueException("Erro: Valor para depósito inválido.");
            }
            Saldo = valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidValueException("Erro: Saldo Insuficiente.");
            }

            if (valor > LimiteDeSaque)
            {
                throw new InvalidValueException("Erro: O valor de Saque esta Acima do limite permitido para saque.");
            }

            Saldo -= valor;
        }
    }
}
