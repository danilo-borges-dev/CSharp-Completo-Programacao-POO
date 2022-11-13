namespace Exercicio_55.Models
{
    internal class HourContract
    {
        public DateTime Date { get; private set; } = new DateTime();
        public double ValuePorHour { get; private set; } = new double();
        public int Hours { get; private set; } = new int();

        public HourContract(DateTime date, double valuePorHour, int hours)
        {
            Date = date;
            ValuePorHour = valuePorHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePorHour * Hours;
        }
    }
}
