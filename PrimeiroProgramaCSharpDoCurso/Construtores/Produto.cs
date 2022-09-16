using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Codigo { get; set; }
        public int Quantidade { get; set; }
        public Produto() { }

        public Produto (string nome, double valor, string codigo = "100")
        {
            Nome = nome;
            Valor = valor;
            Codigo = codigo;
        }

        public double ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}, " +
                $"$ {Valor.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, " +
                $"Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
