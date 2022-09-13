using System.Globalization;

namespace Exercicio_04
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public double Imposto { get; set; }

        public void DescontarImposto()
        {
            SalarioLiquido = SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioLiquido += (porcentagem / 100) * SalarioBruto;
            ToString();
        }

        public override string ToString()
        {
            return $"Dados atualizados: {Nome}, ${SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
