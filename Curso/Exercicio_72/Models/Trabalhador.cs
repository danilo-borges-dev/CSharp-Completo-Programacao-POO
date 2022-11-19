using Exercicio_72.Models.Enums;

namespace Exercicio_72.Models
{
    internal class Trabalhador
    {
        public string Nome { get; private set; }
        public Niveis Niveis { get; private set; } = new Niveis();
        public double SalarioBase { get; private set; } = new double();
        public Departamento Departamento { get; set; }

        public List<Contrato> ListaDeContratos = new List<Contrato>();

        public Trabalhador(string
            nome,
            Niveis niveis,
            double salarioBase,
            Departamento departamento
            )
        {
            Nome = nome;
            Niveis = niveis;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(Contrato contrato)
        {
            ListaDeContratos.Add(contrato);
        }

        public void RemoveContrato(Contrato contrato)
        {
            ListaDeContratos.Remove(contrato);
        }

        public double RendaTotal(int mes, int ano)
        {
            double total = SalarioBase;

            foreach (Contrato contrato in ListaDeContratos)
            {
                if (contrato.Data.Month == mes && contrato.Data.Year == ano)
                {
                    total += contrato.ValorTotal();
                }
            }

            return total;
        }
    }
}
