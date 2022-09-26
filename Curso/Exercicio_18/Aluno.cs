using System.Globalization;

namespace Exercicio_18
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        public double[] Notas { get; private set; } = new double[3];

        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

        private double NotaFinal()
        {
            return Notas[0] + Notas[1] + Notas[2];
        }
        public void VerificarAprovacao()
        {
            if (NotaFinal() < 60)
            {
                Console.WriteLine($"Nota Final = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltam {(60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }
            else
            {
                Console.WriteLine($"Nota Final = {NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado");
            }
        }
    }
}
