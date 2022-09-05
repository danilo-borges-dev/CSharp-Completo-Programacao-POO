Console.WriteLine("Digite três números: ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int maior = new int();

maior = Maior(n1, n2, n3);

Console.WriteLine($"Mair número digitado: {maior}");

int Maior(int a, int b, int c)
{
    int maior = new int();
    if (a > b && a > c)
    {
        maior = a;
    }
    else if (b > c)
    {
        maior = b;
    }
    else
    {
        maior = c;
    }
    return maior;
}