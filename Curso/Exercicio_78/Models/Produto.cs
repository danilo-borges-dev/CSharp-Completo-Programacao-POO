namespace Exercicio_78.Models
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
