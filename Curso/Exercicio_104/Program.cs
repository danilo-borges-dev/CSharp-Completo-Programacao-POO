using Exercicio_104.Entities;
using Exercicio_104.Services;
using System.Globalization;

string model;
DateTime start = new DateTime();
DateTime finish = new DateTime();
double pricePerHour = new double();
double pricePerDay = new double();

CarRental carRental;
RentalService rentalservices;

Console.WriteLine("Enter rental data: ");
Console.Write("Car model: ");
model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
start = DateTime.Parse(Console.ReadLine());
Console.Write("Return (dd/MM/yyyy hh:mm): ");
finish = DateTime.Parse(Console.ReadLine());
Console.Write("Enter price per hour: $ ");
pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: $ ");
pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

carRental = new(start, finish, new Vehicle(model));
rentalservices = new(pricePerHour, pricePerDay);

rentalservices.ProcessInvoice(carRental);

Console.WriteLine("\nINVOICE");
Console.WriteLine(carRental.Invoice);
