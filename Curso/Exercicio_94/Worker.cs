using Exercicio_94.Entities;
using Exercicio_94.Entities.Enums;

namespace Exercicio_94
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; } = new WorkerLevel();
        public double BaseSalary { get; private set; } = new double();
        public Department Department { get; private set; }

        public List<HourContract> HourContractList = new List<HourContract>();
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            HourContractList.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            HourContractList.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double total = BaseSalary;
            foreach (HourContract contract in HourContractList)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    total += contract.TotalValue();
                }
            }
            return total;
        }
    }
}
