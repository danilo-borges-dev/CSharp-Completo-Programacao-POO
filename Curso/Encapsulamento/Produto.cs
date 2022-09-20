namespace Encapsulamento
{
    internal class Produto
    {
        private string Nome { get; set; }
        private int Quantidade { get; set;  }
        private double Valor { get; set; }

        public void DefinirNome(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                Nome = nome;
            }
        }
    }
}
