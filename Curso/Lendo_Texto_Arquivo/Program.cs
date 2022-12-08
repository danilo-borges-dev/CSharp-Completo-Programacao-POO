using System.IO;


try
{
    using (StreamWriter sw = new(@"C:/Workspace/arquivo_teste.txt"))
    {
        int n = new int();
        while (n < 10_000)
        {
            sw.Write("Bom dia! ");
            sw.Write("Danilo!");
            n++;
        }
        sw.Close();
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}