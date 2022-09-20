namespace Encapsulamento
{
    internal class Produto
    {
        private string Nome { get; set; }
        private int Quantidade { get; set;  }
        private double Valor { get; set; }

        public Produto(string nome, int quantidade, double valor)
        {
            Nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }

        public void DefinirNome(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                Nome = nome;
            }
            throw new ArgumentNullException(message: "Preencha o Campo Nome");
        }

        public string GetNomeDeCliente()
        {
            return Nome;
        }
    } 
}
