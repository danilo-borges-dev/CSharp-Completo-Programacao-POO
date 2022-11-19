namespace Exercicio_69.Models
{
    internal class Reservation
    {
        public int RoomNumber { get; private set; } = new int();
        public DateTime CheckIn { get; private set; } = new DateTime();
        public DateTime CheckOut { get; private set; } = new DateTime();

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;  // Cast, porque o TotalDays é um Double
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, chech-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nigths.";
        }
    }
}
