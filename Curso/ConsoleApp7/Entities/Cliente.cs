namespace ConsoleApp7.Entities
{
    internal class Cliente
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string NomeCompleto => Nome + Sobrenome;
        public string NomeCompleto2() => Nome + Sobrenome;
    }
}
