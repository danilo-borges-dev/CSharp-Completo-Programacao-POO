using Exercicio_55.Models.Enums;

namespace Exercicio_55.Models
{
    internal class Worker : Person
    {
        public WorkerLevel WorkerLevel { get; private set; } = new WorkerLevel();
        public double BaseSalary { get; private set; } = new double();

        public Department Department;

        List<HourContract> ContractsList = new List<HourContract>();

        public Worker(
            WorkerLevel workerLevel
            , double baseSalary
            , Department department
            , string name) : base(name)
        {
            WorkerLevel = workerLevel;
            BaseSalary = baseSalary;
            Department = department;
            Name = name;
        }

        public void AddContract(HourContract contract)
        {
            ContractsList.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            ContractsList.Remove(contract);
        }

        public double InCome(int moth, int year)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in ContractsList)
            {
                if (contract.Date.Month == moth && contract.Date.Year == year)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
