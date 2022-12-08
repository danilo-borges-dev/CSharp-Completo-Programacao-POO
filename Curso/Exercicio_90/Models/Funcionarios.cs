namespace Exercicio_90.Models
{
    internal class Funcionarios
    {
        readonly int _id;
        public string Nome { get; private set; }
        public double Salario { get; private set; } = new double();
        public Funcionarios(int id, string nome, double salario)
        {
            _id = id;
            Nome = nome;
            Salario = salario;
        }
        public int GetId ()
        {
            return _id;
        }
        public void AumentarSalario (double porcentagem)
        {
            Salario = Salario * (porcentagem / 100) + Salario;
        }
    }
}
