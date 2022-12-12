
int[,] mat;
int n = new int();
int qtdNegativos = new int();

Console.Write("Informe o valor de n: ");
n = int.Parse(Console.ReadLine());

mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    Console.Write($"\nInforme {n} números na mesma linha: ");
    string[] s = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(s[j]);
        if (mat[i,j] < 0)
        {
            qtdNegativos++;
        }
    }
}

Console.WriteLine("\nDiagonal: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write(mat[i, j] + " ");
        }
    }
}
Console.WriteLine("Total de negativos: " + qtdNegativos);