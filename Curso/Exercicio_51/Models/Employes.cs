namespace Exercicio_51.Models
{
    internal class Employes
    {
        public int Id { get; private set; } = new int();
        public double Salario { get; private set; } = new double();
        public string Nome { get; private set; }

        public Employes(int id, double salario, string nome)
        {
            Id = id;
            Salario = salario;
            Nome = nome;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (Salario * porcentagem / 100); 
        }
    }
}
