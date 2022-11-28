
int integerNumber = new int();
int[,] mat;
int negativeNumbersTotal = new int();

Console.Write("Informe um número inteiro: ");
integerNumber = int.Parse(Console.ReadLine());
mat = new int[integerNumber, integerNumber];

for (int i = 0; i < integerNumber; i++)
{
    Console.Write($"\nInforme na mesma linha {integerNumber} números = ");
    string[] numbers = Console.ReadLine().Split(" ");

    for (int j = 0; j < integerNumber; j++)
    {
        mat[i, j] = int.Parse(numbers[j]);
        if (mat[i, j] < 0)
        {
            negativeNumbersTotal++;
        }
    }
}

Console.WriteLine();
for (int i = 0; i < integerNumber; i++)
{
    for (int j = 0; j < integerNumber; j++)
    {
        if (i == j)
        {
            Console.Write($"{mat[i,j]}, ");
        }
    }
}

Console.WriteLine($"\nNumbers negatives total = {negativeNumbersTotal}");