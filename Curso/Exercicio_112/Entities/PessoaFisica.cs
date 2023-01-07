namespace Exercicio_112.Entities
{
    internal sealed class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; private set; }
        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double CalcularImporto()
        {
            if (RendaAnual < 20_000.00)
            {
                if (GastosComSaude > 0)
                {
                    return (RendaAnual * 0.15) - (GastosComSaude * 0.50);
                }
                return RendaAnual * 0.15;
            }
            if (GastosComSaude > 0)
            {
                return ((RendaAnual * 0.25) - (GastosComSaude * 0.50));
            }
            return RendaAnual * 0.25;
        }
    }
}
