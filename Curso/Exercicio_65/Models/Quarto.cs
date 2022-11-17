namespace Exercicio_65.Models
{
    internal class Quarto
    {
        public int Numero { get; private set; } = new int();
        public Estudante Estudante { get; private set; }

        public Quarto(int numero, Estudante estudante)
        {
            Numero = numero;
            Estudante = estudante;
        }
    }
}
