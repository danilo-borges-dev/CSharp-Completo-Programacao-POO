using System.Globalization;

namespace Exercicio_05
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas = new double[3];
        public double NotaFinal { get; set; }
        public string SituacaoFinal { get; set; }

        public void CalcularNotaFinal()
        {
            NotaFinal = Notas[0] + Notas[1] + Notas[2];
        }

        public void VerificarAprovacaoFinal()
        {
            if (NotaFinal >= 60)
            {
                SituacaoFinal = "APROVADO";
            }
            else
            {
                SituacaoFinal = "REPROVADO";
            }
        }
    }
}
