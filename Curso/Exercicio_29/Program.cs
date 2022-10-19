using Exercicio_29;

Aluno aluno;
string nome;
double[] notas = new double[3];
    
Console.Write("Informe o nome do aluno: ");
nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
notas[0] = double.Parse(Console.ReadLine());
notas[1] = double.Parse(Console.ReadLine());
notas[2] = double.Parse(Console.ReadLine());

aluno = new(nome, notas);
aluno.CalcularNotaFinal();

