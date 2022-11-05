namespace Exercicio_46
{
    internal class Quarto
    {
        public int Numero { get; private set; }
        public Estudante Hospede { get; private set; }

        public Quarto(int numero, Estudante hospede)
        {
            Numero = numero;
            Hospede = hospede;
        }
    }
}
