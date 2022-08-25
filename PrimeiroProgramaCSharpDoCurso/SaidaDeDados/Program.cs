using System.Globalization;

string Nome = "Danilo";
int Idade = 29;
char Sexo = 'M';
double Salario = 5_320.55789;

// Controlar a Quantidade de Casas Decimais que serão exibidas:
Console.WriteLine(Salario.ToString("F2")); // Duas casas Decimais
Console.WriteLine(Salario.ToString("C"));  // Resultado no console R$ 5.320,55

Console.WriteLine("\n");

// Apresentar o Resultado com o Ponto como separador das Casas Decimais:
Console.WriteLine(Salario.ToString("F2", CultureInfo.InvariantCulture));  // Resultado no Console 5320.55 - FormatProvider, como eu gostaria de formatar o meu número

Console.WriteLine("\n");

// Placeholders:
Console.WriteLine("{0} tem {1} anos de idade e o seu Salário é {2:F2}.\n", Nome, Idade, Salario); // Pode alterar {2:C}

// Concatenação:
Console.WriteLine(Nome + " tem " + Idade + " anos de idade e o seu Salário é " + Salario.ToString("F2", CultureInfo.InvariantCulture) + ".\n");

// Interpolação:    
Console.WriteLine($"{Nome} tem {Idade} anos de idade e o seu Salário é {Salario:F2}.");  // Pode alterar {2:C}

