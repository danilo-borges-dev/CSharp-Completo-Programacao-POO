namespace Exercicio_78.Models
{
    internal class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataAniversario { get; private set; } = new DateTime();
        public Cliente(string nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
        }
    }
}
