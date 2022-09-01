using System.Globalization;

//string condicao = " ";

//do
//{
//    int num = new int();
//    Console.WriteLine("Digite um número ou digite s para sair: ");
//    condicao = Console.ReadLine();


//    if (condicao == "s")
//    {
//        return;
//    }
//    else
//    {
//        num = int.Parse(condicao);
//        //if (num > 0)
//        //{
//        //    Console.WriteLine("O número é positivo.");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("O número é negativo.");
//        //}

//        //if (num % 2 == 0)
//        //{
//        //    Console.WriteLine("O número é par.");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("O número é impar.");
//        //}

//    }


//} while (condicao.ToLower() != "s");

//string[] valores = Console.ReadLine().Split(" ");

//int a = int.Parse(valores[0]);
//int b = int.Parse(valores[1]);

//if (a % 2 == 0 && b % 2 == 0)
//{
//    Console.WriteLine("São Multiplos.");
//}
//else
//{
//    Console.WriteLine("Não são Multiplos.");
//}



//int result = a - b;

//if (result == 0)
//{
//    Console.WriteLine("O jogo durou 24 horas.");
//}
//else
//{
//    if (a > b)
//    {
//        result = 24 - a + b;
//    }
//    else
//    {
//        a = 24 - a;
//        b = 24 - b;
//        result = a - b;
//    }
//    Console.WriteLine($"O jogo durou {result} horas.");
//}


//Console.WriteLine("Entrada: ");
//string[] ordem = Console.ReadLine().Split(" ");

//int produdo = int.Parse(ordem[0]);
//int quantidade = int.Parse(ordem[1]);
//double valor = new double();

//switch (produdo)
//{
//    case 1:
//        valor = 4.0 * quantidade;
//        break;
//    case 2:
//        valor = 4.50 * quantidade;
//        break;
//    case 3:
//        valor = 5.00 * quantidade;
//        break;
//    case 4:
//        valor = 2.00 * quantidade;
//        break;
//    case 5:
//        valor = 1.50 * quantidade;
//        break;
//    default:
//        Console.WriteLine("Valor inválido.");
//        break;
//}

//Console.WriteLine($"Total: {valor.ToString("F2", CultureInfo.InvariantCulture)}");

