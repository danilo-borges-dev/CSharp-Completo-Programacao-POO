using Exercicio_52.Models.Enums;
using Exercicio_52.Models;

namespace Exercicio_52.Models
{
    internal class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; } = new WorkerLevel();
        public double BaseSalary { get; private set; } = new double();


        // Aqui temos Duas Compósições de Objetos ----------------------------------
        public Department Department { get; set; }  
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        // --------------------------------------------------------------------------


        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double inCome(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
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
            return $"Nome: {Name} \nDepartamento: {Department.Name}";
        }
    }
}
