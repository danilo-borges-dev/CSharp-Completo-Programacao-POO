using Exercicio_118.Entities.Enums;

namespace Exercicio_118.Entities
{
    internal class Worker
    {
        public string Name { get; private set; }
        public EWorkerLevel WorkerLevel { get; private set; }
        public double BaseSalary { get; private set; }
        public Department Department { get; private set; }
        
        private List<HourContract> HourContracts = new List<HourContract>();
        public Worker(string name, EWorkerLevel workerLevel, double baseSalary, Department department)
        {
            Name = name;
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            HourContracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            HourContracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double total = BaseSalary;
            foreach (var contract in HourContracts)
            {
                if (contract.Date.Month == month && contract.Date.Year == year)
                {
                    total += contract.TotalValue();
                }
            }
            return total;
        }
    }
}
