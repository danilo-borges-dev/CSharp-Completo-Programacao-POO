namespace ConsoleApp7.Entities
{
    internal class Cliente
    {
        public string Nome = string.Empty;
        public string Sobrenome = string.Empty;
        public string NomeCompletoProp => Nome + Sobrenome;
        public string NomeCompletoMet() => Nome + Sobrenome;
    }
}
