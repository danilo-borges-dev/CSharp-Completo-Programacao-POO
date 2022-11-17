namespace Exercicio_65.Models
{
    internal class Estudante
    {
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
