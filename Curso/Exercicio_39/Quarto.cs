namespace Exercicio_39
{
    internal class Quarto
    {
        public string Situcao { get; private set; } = "Vago";
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Quarto(string nome, string email)
        {
            Nome = nome;
            Email = email;
            Situcao = "Ocupado";
        }
    }
}
