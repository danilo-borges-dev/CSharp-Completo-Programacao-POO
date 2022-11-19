using Exercicio_69.Models;
using Exercicio_69.Models.Exceptions;

int number = new int();
DateTime checkIn = new DateTime();
DateTime checkOut = new DateTime();

Reservation reservation;


try
{
    Console.Write("Room Number: ");
    number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation = new(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.Write("\nEnter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);

    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException ex)
{
    Console.WriteLine("Error reservation: " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Format error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unexpected error: " + ex.Message);
}





