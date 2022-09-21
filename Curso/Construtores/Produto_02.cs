namespace Construtores
{
    internal class Produto_02
    {
        private string Nome { get; set; }
        private int _quantidade = new int();
        private double _peso;
        public double Valor { get; private set; }

        public Produto_02(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public Produto_02(string nome, double valor, int quantidade ) : this (nome, valor)
        {
            _quantidade = quantidade;
        }

        public Produto_02(string nome, double valor, int quantidade, double peso) : this (nome, valor, quantidade)
        {
            _peso = peso;
        }
    }
}
