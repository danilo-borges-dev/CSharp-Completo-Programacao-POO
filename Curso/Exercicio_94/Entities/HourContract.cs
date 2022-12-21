namespace Exercicio_94.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; private set; } = new DateTime();
        public double ValuesPerHour { get; private set; } = new double();
        public int Hours { get; private set; } = new int();
        public HourContract(DateTime date, double valuesPerHour, int hours)
        {
            Date = date;
            ValuesPerHour = valuesPerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuesPerHour * Hours;
        }
    }
}
