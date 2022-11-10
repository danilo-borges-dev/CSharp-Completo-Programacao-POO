using Revisando_Enums.Models;
using Revisando_Enums.Models.Enums;

Order order = new(100, 15.12, Status.Shipped);

string status = Status.Delivered.ToString();
Console.WriteLine(order);

Status st;
Enum.TryParse("Delivered", out st);
Console.WriteLine(st);