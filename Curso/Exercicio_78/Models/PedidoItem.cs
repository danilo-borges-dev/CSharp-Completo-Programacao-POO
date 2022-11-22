namespace Exercicio_78.Models
{
    internal class PedidoItem
    {
        public int Quantidade { get; private set; } = new int();
        public double Valor { get; private set; } = new double();
        public Produto Produto { get; set; }

        public PedidoItem(int quantidade, double valor, Produto produto)
        {
            Quantidade = quantidade;
            Valor = valor;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Quantidade * Valor;
        }
    }
}
