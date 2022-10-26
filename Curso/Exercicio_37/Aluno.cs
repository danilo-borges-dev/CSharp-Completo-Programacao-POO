using System.Globalization;

namespace Exercicio_37
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        public double[] Notas { get; private set; } = new double[3];
        private string _situacaoAluno;
        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = new double();
            for (int i = 0; i < Notas.Length; i++)
            {
                notaFinal += Notas[i];
            }
            return notaFinal;
        }

        public override string ToString()
        {
            double notaFinal = CalcularNotaFinal();
            if (CalcularNotaFinal() < 60)
            {
                _situacaoAluno = "Reprovado";
                return $"\nNota Final {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                    $"{_situacaoAluno}\n" +
                    $"Faltam: {(60 - notaFinal).ToString("F2", CultureInfo.InvariantCulture)} pontos";
            }
            _situacaoAluno = "Aprovado";
            return $"\nNota Final {CalcularNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"{_situacaoAluno}";
        }
    }
}
