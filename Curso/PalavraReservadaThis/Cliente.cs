namespace PalavraReservadaThis
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public double Peso { get; set; }
        public string Raca { get; set; }
        public Cliente() { }
        public Cliente(string nome, int idade, char sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }
        public Cliente(string nome, int idade, char sexo, double peso) : this (nome, idade, sexo)
        {
            Nome = nome;
            Sexo = sexo;
            Peso = peso;
        }
        public Cliente(string nome, int idade, char sexo, double peso, string raca) : this (nome, idade, sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Peso = peso;
            Raca = raca;
        }
    }
}
