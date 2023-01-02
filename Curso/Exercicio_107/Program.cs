using Exercicio_107.Entities;
using Exercicio_107.Services;
using System.Globalization;

Console.WriteLine("Enter car data:");
Console.Write("Car model: ");
string carModel = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy): ");
DateTime start = DateTime.Parse(Console.ReadLine());
Console.Write("Return (dd/MM/yyyy): ");
DateTime finish = DateTime.Parse(Console.ReadLine());

Console.Write("Enter price per hour $ ");
double pricePerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day $ ");
double pricePerDay= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new(start, finish, new Vehicle(carModel));

RentalService rentalService = new(pricePerhour, pricePerDay);

rentalService.ProcessInvoice(carRental);

Console.WriteLine(carRental.Invoice);

