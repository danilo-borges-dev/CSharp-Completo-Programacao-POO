using Exercicio_69.Models.Exceptions;

namespace Exercicio_69.Models
{
    internal class Reservation
    {
        public int RoomNumber { get; private set; } = new int();
        public DateTime CheckIn { get; private set; } = new DateTime();
        public DateTime CheckOut { get; private set; } = new DateTime();

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must after check-in date.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;  // Cast, porque o TotalDays é um Double
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
               throw new DomainException("Error in reservation: Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must after check-in date.");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, chech-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nigths.";
        }
    }
}
