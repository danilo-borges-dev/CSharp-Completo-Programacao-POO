using System.Globalization;

namespace Exercicio_29
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

        public void CalcularNotaFinal()
        {
            double mediaFinal = new double();
            for (int i = 0; i < Notas.Length; i++)
            {
                mediaFinal += Notas[i];
            }
            if (mediaFinal < 60)
            {
                Console.WriteLine($"Nota Final {mediaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltam {(60 - mediaFinal).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"Nota Final {mediaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aprovado");
            }
        }
    }
}
