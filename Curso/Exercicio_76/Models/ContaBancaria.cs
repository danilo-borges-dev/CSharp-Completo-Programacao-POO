using Exercicio_76.Models.Exceptions;
using System.Globalization;

namespace Exercicio_76.Models
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
            if (limiteDeSaque < 0)
            {
                throw new ValorDinheiroInvalidoException($"Erro: Valor para Saque Inicial não pode ser $ {limiteDeSaque.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            LimiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ValorDinheiroInvalidoException($"Erro: O valor de depósito $ {valor.ToString("F2", CultureInfo.InvariantCulture)} está inválido.");
            }

            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ValorDinheiroInvalidoException($"Erro: Saldo $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)} Insuficiente");
            }
            if (valor > LimiteDeSaque)
            {
                throw new ValorDinheiroInvalidoException($"Erro: Valor acima do limite permitido para Saque $ {LimiteDeSaque.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Saldo -= valor;
        }
    }
}
