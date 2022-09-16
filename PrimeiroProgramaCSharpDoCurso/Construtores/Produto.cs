namespace Construtores
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }
        public Produto() { }

        public Produto (string nome, double valor, string codigo = "100")
        {
            Nome = nome;
            Valor = valor;
            Codigo = codigo;
        }
    }
}
