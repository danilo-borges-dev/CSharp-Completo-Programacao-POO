using Exercicio_53.Models.Enums;

namespace Exercicio_53.Models
{
    internal class Worker : Person
    {
        public WorkerLevel Level { get; private set; } = new WorkerLevel(); // Valor default 0 que é igual a Junior
        public double BaseSalary { get; private set; } = new double();

        List<HourContract> ContractsList = new List<HourContract>();  // Aqui temos a Composição Tem Vários

        Department Department;  // Aqui temos a Composição Tem Um

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) : base(name)
        {
            Level = level;
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

        public double InCome(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in ContractsList)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

        public override string ToString()
        {
            return $"Nome: {Name} \nDepartment: {Department.Name}";
        }
    }
}
