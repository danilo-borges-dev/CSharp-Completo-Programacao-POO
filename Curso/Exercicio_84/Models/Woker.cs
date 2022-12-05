using Exercicio_84.Models.Enums;

namespace Exercicio_84.Models
{
    internal class Woker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; } = new double();
        public Department Department { get; private set; }

        private List<HourContract> ContractList = new List<HourContract>();

        public Woker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            ContractList.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            ContractList.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double total = new double();
            foreach (HourContract contract in ContractList)
            {
                if (year == contract.Date.Year && month == contract.Date.Month)
                {
                    total += contract.TotalValue();
                }
            }
            return total;
        }
    }
}
