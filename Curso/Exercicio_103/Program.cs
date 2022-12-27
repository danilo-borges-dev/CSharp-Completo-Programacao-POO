
int number = new int();
int[,] mat;
int negativeNumber = new int();

Console.Write("Informe um número inteiro: ");
number = int.Parse(Console.ReadLine());
mat = new int[number, number];

for (int i = 0; i < number; i++)
{
	Console.Write($"Digite {number} quantidade de números na mesma linha: ");
	string[] numbers = Console.ReadLine().Split(" ");
	for (int j = 0; j < number; j++)
	{
		mat[i, j] = int.Parse(numbers[j]);
		if (mat[i,j] < 0)
		{
			negativeNumber++;
        }
	}
}

Console.WriteLine("\nMain diagonal: ");
for (int i = 0; i < number; i++)
{
	for (int j = 0; j < number; j++)
	{
		if (i == j)
		{
			Console.Write($"{mat[i,j]} ");
		}
	}
}

Console.WriteLine("\nNegative numbers: " + negativeNumber);