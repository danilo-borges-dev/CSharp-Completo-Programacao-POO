
string mensagem = "   Que a mente seja plena para construir e mentalizar coisas boas na vida no presente e futuro   ";

Console.WriteLine(" - " + mensagem.ToUpper() + " - ");
// Saída no Console: "-    QUE A MENTE SEJA PLENA PARA CONSTRUIR E MENTALIZAR COISAS BOAS NA VIDA NO PRESENTE E FUTURO    -"
Console.WriteLine(" - " + mensagem.ToLower() + " - ");
// Saída no Console: " -    que a mente seja plena para construir e mentalizar coisas boas na vida no presente e futuro    -"
Console.WriteLine(" - " + mensagem.Trim() + " - ");
// Saída no Console: "- Que a mente seja plena para construir e mentalizar coisas boas na vida no presente e futuro -"
Console.WriteLine(mensagem.IndexOf("bc"));
// Saída no Console: -1 porque não existe na string conjunto de caracteres bc
Console.WriteLine(mensagem.IndexOf("ment"));
// Saída no Console: 9 que é a primeira posição/index que se inicia "ment"
Console.WriteLine(mensagem.LastIndexOf("ment"));
// Saída no Console: 43 que é a última posição/index que se inicia "ment"

// Recorta um pedaço da string de acordo com as condições passadas por Parâmetro
Console.WriteLine(mensagem.Substring(6));
// Saída no Console: a mente seja plena para construir e mentalizar coisas boas na vida no presente e futuro
Console.WriteLine(mensagem.Substring(6, 10));
// Saída no Console: a mente s

// Troca um caractere ou um conjunto de caracteres por outro.
Console.WriteLine(mensagem.Replace("mente", "coração"));
// Saída no Console: Que a coração seja plena para construir e mentalizar coisas boas na vida no presente e futuro

// Verificar se a String é Vazia
Console.WriteLine(String.IsNullOrEmpty(mensagem));
// Saída no Console: False

// Testa se a variável é nula ou se é conjunto de espaços em branco " ".
Console.WriteLine(String.IsNullOrWhiteSpace(mensagem));
// Saída no Console: False





