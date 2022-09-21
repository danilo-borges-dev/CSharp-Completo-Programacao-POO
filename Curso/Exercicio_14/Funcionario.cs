namespace Exercicio_14
{
    internal class Funcionario
    {
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}
