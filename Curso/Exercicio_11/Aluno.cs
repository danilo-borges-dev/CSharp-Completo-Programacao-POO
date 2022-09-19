using System.Globalization;

namespace Exercicio_11
{
    internal class Aluno
    {
        private string _nome { get; }
        private double[] _notas { get; }
        private string _situacaoDoAluno { get; set;  }
        public Aluno() { }
        public Aluno(string nome, double[] notas)
        {
            _nome = nome;
            _notas = notas;
        }

        public string CalcularNota()
        {
            double notas = _notas.Sum();
            if (notas <= 60)
            {
                _situacaoDoAluno = "\nREPROVADO";
                return $"Nota Final = {notas.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"{_situacaoDoAluno}\n" +
                    $"Faltam {(60 - notas).ToString("F2", CultureInfo.InvariantCulture)} Pontos.";
            }
            _situacaoDoAluno = "\nAPROVADO";
            return $"Nota final = {notas.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"{_situacaoDoAluno}\n";
        }
    }
}
