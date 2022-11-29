string msg = "  Que a mente seja plena para construir e mentalizar coisas boas na vida no presente e no futuro  ";

Console.WriteLine(msg.ToUpper());
Console.WriteLine(msg.ToLower());
Console.WriteLine(msg.Trim());
Console.WriteLine(msg.IndexOf("para"));
Console.WriteLine(msg.Substring(10, 10));
Console.WriteLine(msg.Replace("para", "PARA"));
Console.WriteLine(String.IsNullOrEmpty(msg));
Console.WriteLine(String.IsNullOrWhiteSpace(msg));