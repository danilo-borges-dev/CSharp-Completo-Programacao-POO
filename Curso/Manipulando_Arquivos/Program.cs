using System.IO;
using System.Text;

//try
//{
//    StreamReader sr = new(@"C:\Workspace\arquivos.txt");
//    string line = sr.ReadLine();

//    while (line != null)
//    {
//        Console.WriteLine(line);
//        line = sr.ReadLine();
//    }
//    sr.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("\nExcetion: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("\nExceuting finally block.");
//}

//try
//{
//    StreamWriter sw = new(@"C:\Workspace\arquivos2.txt");
//    sw.WriteLine("Danilo da Silva Borges");
//    sw.WriteLine("Minas Gerais");
//    sw.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Exception: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Executing finally block.");
//}

//try
//{
//    StreamWriter sw = new(@"C:\Workspace\arquivos.txt", true, Encoding.ASCII);

//    for (int i = 0; i < 10; i++)
//    {
//        Console.Write("Digite um Caractere: ");
//        char c = char.Parse(Console.ReadLine());
//        sw.Write(c);
//    }
//    sw.Close();
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Exception: " + ex.Message);
//}
//finally
//{
//    Console.WriteLine("Executing finally block.");
//}

try
{
    FileInfo fileInfo = new(@"C:\Workspace\arquivos.txt");
}
catch (Exception)
{

    throw;
}