using ConsoleApp7.Entities;

Cliente cliente = new Cliente();

cliente.Nome = "João";
cliente.Sobrenome = "Silva";

Console.WriteLine(cliente.NomeCompletoProp);
Console.WriteLine(cliente.NomeCompletoMet());

Console.WriteLine(nameof(cliente.NomeCompletoProp));
Console.WriteLine(nameof(cliente));

int? n = new int();
n = null;

Cliente client2 = new(nome: "José", sobrenome: "Maria");
Cliente cliente3 = new(nome: "Maria", sobrenome: "Gonçalvez");