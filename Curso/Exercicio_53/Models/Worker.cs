using Exercicio_53.Models.Enums;

namespace Exercicio_53.Models
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; private set; } = new WorkerLevel(); // Valor default 0 que é igual a Junior
        public double BaseSalary { get; private set; } = new double();

        List<HourContract> ContractsList = new List<HourContract>();

        Department Department;

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            Name = name;
        }
    }
}
