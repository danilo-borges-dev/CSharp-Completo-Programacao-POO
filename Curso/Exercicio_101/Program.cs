using Exercicio_101.Entities;
using Exercicio_101.Services;
using System.Globalization;

string carModel;
DateTime dataPickup = new DateTime();
DateTime dataReturn = new DateTime();
double pricePerHour = new double();
double pricePerDay = new double();

CarRental carRendal;
RentalService rentalService;

Console.WriteLine("Enter rental data: ");
Console.Write("Car model: ");
carModel = Console.ReadLine();
Console.Write("Pickup (DD/MM/YYYY): ");
dataPickup = DateTime.Parse(Console.ReadLine());
Console.Write("Return (DD/MM/YYYY): ");
dataReturn = DateTime.Parse(Console.ReadLine());

Console.Write("Price per hour: ");
pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

carRendal = new CarRental(dataPickup, dataReturn, new Vehicle(carModel));

rentalService = new(pricePerHour, pricePerDay);

rentalService.ProcessInvoice(carRendal);

Console.WriteLine("\nINVOICE:");
Console.WriteLine(carRendal.Invoice);