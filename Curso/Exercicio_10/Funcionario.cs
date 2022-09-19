namespace Exercicio_10
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public Funcionario() { }

        public Funcionario(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            porcentagem /= 100;
            SalarioBruto += SalarioBruto * porcentagem - Imposto;
        }
    }
}
