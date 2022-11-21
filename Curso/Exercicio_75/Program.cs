using Exercicio_75.Models;

Postagem p1 = new(new DateTime(2018, 06, 21, 13, 05, 44), "Viajando para Nova Zelandia", "Estou indo visitar um lindo país", 12);
Postagem p2 = new(new DateTime(2018, 07, 28, 23, 14, 19), "Boa noite pessoal", "Vejo vocês amanhã", 5);

p1.AdicionarComentario(new Comentario("Tenha uma boa viagem."));
p1.AdicionarComentario(new Comentario("Que legal!"));

p2.AdicionarComentario(new Comentario("Boa noite!"));
p2.AdicionarComentario(new Comentario("Que a força esteja com você."));

Console.WriteLine(p1);
Console.WriteLine();
Console.WriteLine(p2);