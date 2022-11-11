using Exercicio_52.Models.Enums;

namespace Exercicio_52.Models
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; } = new WorkerLevel();
        public double BaseSalary { get; private set; } = new double();
        public Department Department { get; set; }  // Nesta Linha temos uma composição de Objetos

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double inCome(int year, int month)
        {

        }
    }
}
