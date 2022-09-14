using System.Globalization;

namespace Exercicio_05
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas = new double[3];
        public double NotaFinal { get; set; }
        public string SituacaoFinal { get; set; }
        public double PontosParaSerAprovado { get; set; }

        public void CalcularNotaFinal()
        {
            NotaFinal = Notas[0] + Notas[1] + Notas[2];

            VerificarAprovacaoFinal();
            ToString();
        }

        public void VerificarAprovacaoFinal()
        {
            if (NotaFinal >= 60)
            {
                SituacaoFinal = "APROVADO";
            }
            else
            {
                PontosParaSerAprovado = 60 - NotaFinal;
                SituacaoFinal = "REPROVADO";
            }
        }

        public override string ToString()
        {
            if (NotaFinal >= 60)
            {
                Console.WriteLine($"\nNOTA FINAL = {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n{SituacaoFinal}");
            }
            else
            {
                Console.WriteLine($"\nNOTA FINAL = {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n{SituacaoFinal}\nFALTARAM {PontosParaSerAprovado.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
            return "";
        }
    }
}
