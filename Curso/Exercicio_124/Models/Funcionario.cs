namespace Exercicio_124.Models
{
    internal class Funcionario
    {
        public int Id { get; } 
        public string Nome { get; private set; } = string.Empty;
        public double Salario { get; private set; } = new double();
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentarSalario (double porcentagem)
        {
            if (porcentagem > 0.0)
            {
                Salario = ((porcentagem / 100) * Salario) + Salario;
            }
        }
    }
}
