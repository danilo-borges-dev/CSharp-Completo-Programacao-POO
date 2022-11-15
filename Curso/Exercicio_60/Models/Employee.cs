using System.Globalization;
using System.Text;

namespace Exercicio_60.Models
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; } = new int();
        public double ValuePerHour { get; private set; } = new double();

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.Append(Name);
            sb.Append(" - $ ");
            sb.Append(Payment().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();   
        }
    }
}
