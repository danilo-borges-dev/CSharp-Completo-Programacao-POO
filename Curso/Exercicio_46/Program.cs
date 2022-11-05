using Exercicio_46;
using System.Collections.Generic;

string nomeEstudante;
string emailEstudante;
bool condicao = true;
int nEstudantes = new int();
int nQuarto = new int();

List<Quarto> quartos = new List<Quarto>();
Estudante estudante;

do
{
    Console.Write("Qual o número de Estudantes: ");
    nEstudantes = int.Parse(Console.ReadLine());

    if (nEstudantes > 10)
    {
        Console.WriteLine("Temos apenas 10 Quatros.");
        condicao = true;
    }
    else
    {
        condicao = false;
    }

} while (condicao);

for (int i = 0; i < nEstudantes; i++)
{
    condicao = true;
    do
    {
        Console.Write($"\nInforme o Número do Quarto do {i + 1}º Estudante: ");
        nQuarto = int.Parse(Console.ReadLine());

        if (quartos.Count() != 0)
        {
            foreach (var item in quartos)
            {
                if (item.Numero == nQuarto)
                {
                    Console.Write("Quarto Ocupado.");
                    break;
                }
                else
                {
                    condicao = false;
                }
            }
        }
        else
        {
            condicao = false;
        }

    } while (condicao);

    Console.Write("Informe o Nome do Estudante: ");
    nomeEstudante = Console.ReadLine();
    Console.Write("E-mail: ");
    emailEstudante = Console.ReadLine();

    estudante = new Estudante(nomeEstudante, emailEstudante);
    quartos.Add(new Quarto(nQuarto, estudante));
}

foreach (var item in quartos)
{
    Console.WriteLine($"\nQuarto {item.Numero} - Nome: {item.Hospede.Nome}, E-mail: {item.Hospede.Email}");
}
