// See https://aka.ms/new-console-template for more information
string[] cores = new string[3];
Console.WriteLine("Digite três cores: ");
cores = Console.ReadLine().Split(" ");

Console.WriteLine(cores[0]);
Console.WriteLine(cores[1]);
Console.WriteLine(cores[2]);