namespace Exercicio_13
{
    internal class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public Pessoa (string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int Getidade()
        {
            return Idade;
        }
    }
}
