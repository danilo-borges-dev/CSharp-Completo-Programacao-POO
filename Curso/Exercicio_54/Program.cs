using Exercicio_54.Models;

Comment c1 = new("Have a nice trip.");
Comment c2 = new("Whoe tha's awesome!");

Post post1 = new(new DateTime (2018, 07, 28, 23, 14, 19), "Traveling to New Zealand", 12, "I'm going to visit wonderful country!");
post1.AddComment(c1);
post1.AddComment(c2);

Comment c3 = new("Good nigth");
Comment c4 = new("May the Force be with you");

Post post2 = new(new DateTime(2018, 07, 28, 23, 14, 19), "Good night guys", 5, "See you tomorrow");
post2.AddComment(c3);
post2.AddComment(c4);


Console.WriteLine(post1);
Console.WriteLine(post2);