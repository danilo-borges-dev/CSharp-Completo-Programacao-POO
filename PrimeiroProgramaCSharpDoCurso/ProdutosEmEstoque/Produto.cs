using System.Globalization;

namespace ProdutosEmEstoque
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdEstoque { get; set; }

        public void AdicionarNoEstoque(int qtd)
        {
            QtdEstoque += qtd;
            ToString();
        }

        public void RemoverDoEstoque(int qtd)
        {
            QtdEstoque -= qtd;
            ToString();
        }

        public double ValorTotalEmEstoque()
        {
            return QtdEstoque * Preco;
        }

        public override string ToString()
        {
            Console.WriteLine($"\nDados atualizados: {Nome}, ${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {QtdEstoque} unidades, Total: ${(Preco * QtdEstoque).ToString("F2", CultureInfo.InvariantCulture)}");
            return "";
        }
    }
}
