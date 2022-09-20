namespace Encapsulamento
{
    internal class Produto
    {
        private string _nome { get; set; }


        public int Quantidade { get; private set; }


        public double Valor { get; private set; }


        public Produto(string nome, int quantidade, double valor)
        {
            _nome = nome;
            Quantidade = quantidade;
            Valor = valor;
        }


        public string Nome 
        { 
            get 
            {
                return _nome; 
            } 
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    Nome = value;
                }
                throw new ArgumentNullException();
            } 
        }


        public void DefinirNome(string nome)
        {
            if (String.IsNullOrEmpty(nome))
            {
                Nome = nome;
            }
            throw new ArgumentNullException();
        }
    } 
}
