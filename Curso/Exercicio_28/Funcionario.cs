using System.Globalization;

namespace Exercicio_28
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Imposto { get; private set; }

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }
        public double CalcularSalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"\nDados atualizados: {Nome}, $ {CalcularSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
