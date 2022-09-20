namespace PalavraReservadaThis
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto() { }
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public Produto(string nome, double valor, int quantidade) : this (nome, valor)
        {
            Quantidade = quantidade;
        }
    }
}
