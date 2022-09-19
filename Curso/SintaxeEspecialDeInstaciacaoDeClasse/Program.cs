using SintaxeEspecialDeInstaciacaoDeClasse;

string nome = "Batata";
double valor = 5_00;
int quantidade = 100;

Produto p = new(nome, valor) { Quantidade = quantidade };

Console.WriteLine("Hello, World!");
