namespace Exercicio_106.Entities
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
