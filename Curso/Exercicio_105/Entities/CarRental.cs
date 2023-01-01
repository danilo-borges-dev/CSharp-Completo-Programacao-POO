namespace Exercicio_105.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; private set; }
        public DateTime Finish { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; private set; }
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
