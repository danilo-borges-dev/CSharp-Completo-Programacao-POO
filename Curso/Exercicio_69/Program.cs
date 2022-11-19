using Exercicio_69.Models;

int number = new int();

Reservation reservation;

Console.Write("Room Number: ");
number = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());

if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-out date must after check-in date.");
}
else
{
    reservation = new(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);
}


