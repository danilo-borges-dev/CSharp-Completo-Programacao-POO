using Exercicio_106.Entities.Enums;

namespace Exercicio_106.Entities
{
    internal class Trabalhador
    {
        public string Nome { get; private set; }
        public NivelDoTrabalhador NivelDoTrabalhador { get; private set; }
        public double SalarioBase { get; private set; }
        public Departamento Departamento { get; private set; }

        public List<ContratoPorHora> ContratoPorHora = new List<ContratoPorHora>();
        public Trabalhador(string nome, NivelDoTrabalhador nivelDoTrabalhador, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            NivelDoTrabalhador = nivelDoTrabalhador;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AddContrato(ContratoPorHora contrato)
        {
            ContratoPorHora.Add(contrato);
        }
        public void RemoveContrato(ContratoPorHora contrato)
        {
            ContratoPorHora.Remove(contrato);
        }
        public double Recebimento(int mes, int ano)
        {
            double valorTotal = SalarioBase;
            foreach (ContratoPorHora contrato in ContratoPorHora)
            {
                if (mes == contrato.Data.Month && ano == contrato.Data.Year)
                {
                    valorTotal += contrato.ValorTotal();
                }
            }
            return valorTotal;
        }
    }
}
