using ConsoleApp7.Entities;

Cliente cliente = new Cliente();

cliente.Nome = "João";
cliente.Sobrenome = "Silva";

Console.WriteLine(cliente.NomeCompletoProp);
Console.WriteLine(cliente.NomeCompletoMet());