string source = @"C:\Workspace\arquivo.txt";
string target = @"C:\Workspace\aqruivos_2.txt";

try
{
    FileInfo file = new(source);
    file.CopyTo(target);

    string[] nomes = File.ReadAllLines(source);

    foreach (var item in nomes)
    {
        Console.WriteLine();
    }
}
catch (IOException ex)
{
    Console.WriteLine("An error ocurred.");
    Console.WriteLine(ex.Message);
}