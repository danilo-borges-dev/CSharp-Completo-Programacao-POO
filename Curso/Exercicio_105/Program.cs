using Exercicio_105.Entities;

string carModel;
DateTime start = new DateTime();
DateTime finish = new DateTime();

CarRental carRental;

Console.WriteLine("Enter rental data: ");
Console.Write("Car model: ");
carModel = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
start = DateTime.Parse(Console.ReadLine());
Console.Write("Return (dd/MM/yyyy hh:mm): ");
finish = DateTime.Parse(Console.ReadLine());

carRental = new(start, finish, new Vehicle(carModel));