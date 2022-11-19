namespace Exercicio_72.Models
{
    internal class Departamento
    {
        public string Nome { get; private set; }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}
