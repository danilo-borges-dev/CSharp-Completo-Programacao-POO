namespace Exercicio_79.Models
{
    internal class Funcionario
    {
        public int Id { get; private set; } = new int();
        public string Nome { get; private set; }
        public double Salario { get; private set; } = new double();

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }
    }
}
