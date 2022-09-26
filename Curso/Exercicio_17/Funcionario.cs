using System.Globalization;

namespace Exercicio_17
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }
        public double NovoSalario { get; private set; }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double procentagem)
        {
            NovoSalario = (SalarioBruto + (SalarioBruto * (procentagem / 100))) - Imposto;
        }

        public override string ToString()
        {
            return $"Dados atualizados: {Nome}, $ {NovoSalario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
