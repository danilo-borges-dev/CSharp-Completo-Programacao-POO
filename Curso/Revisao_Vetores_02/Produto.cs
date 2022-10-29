namespace Revisao_Vetores_02
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; } = new double();

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
