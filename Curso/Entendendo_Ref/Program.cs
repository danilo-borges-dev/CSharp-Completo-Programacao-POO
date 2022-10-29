using Entendendo_Ref;

//int a = new int();

//Calculadora.Sum(ref a);
//Console.WriteLine(a);

double valorDeAumento = new double();
double salarioAtual = 1000.00;
double porcetagemDeAumento = 10;


Calculadora.AumentarSalario(salarioAtual, porcetagemDeAumento, out valorDeAumento);
Console.WriteLine(valorDeAumento);
Console.WriteLine(Calculadora.Salario);

