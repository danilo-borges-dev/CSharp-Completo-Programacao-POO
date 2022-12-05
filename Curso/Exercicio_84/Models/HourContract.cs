namespace Exercicio_84.Models
{
    internal class HourContract
    {
        public DateTime Date { get; private set; } = new DateTime();
        public double ValuePerHour { get; private set; } = new double();
        public int Hours { get; private set; } = new int();

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
