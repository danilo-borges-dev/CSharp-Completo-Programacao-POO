using System.Runtime.ExceptionServices;

int[,] mat;
int n = new int();
int nNegativos = new int();


Console.Write("Informe um número inteiro: ");
n = int.Parse(Console.ReadLine());
mat = new int[n, n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Digite {n} números na mesma linha: ");
    string[] numeros = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(numeros[j]);
        if (mat[i,j] < 0)
        {
            nNegativos++;
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            Console.Write($"{mat[i,j]} ");
        }
    }
}

Console.WriteLine($"Total de números negativos: {nNegativos}");