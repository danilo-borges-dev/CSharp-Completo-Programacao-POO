namespace ConsoleApp7.Entities
{
    internal class Cliente
    {
        public string Nome = string.Empty;
        public string Sobrenome = string.Empty;
        public string NomeCompletoProp => Nome + Sobrenome;
        public string NomeCompletoMet() => Nome + Sobrenome;
        public Cliente() { }
        public Cliente(string nome, string sobrenome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException(nameof(nome));
            }
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
