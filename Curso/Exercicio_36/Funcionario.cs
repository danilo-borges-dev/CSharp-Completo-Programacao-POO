using System.Globalization;

namespace Exercicio_36
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; } = new double();
        public double Impostos { get; private set; } = new double();

        public Funcionario(string nome, double salario, double impostos)
        {
            Nome = nome;
            Salario = salario;
            Impostos = impostos;
        }

        public double SalarioLiquido()
        {
            return Salario - Impostos;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"\nDados atualizados: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
