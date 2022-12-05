using Exercicio_85.Models;

Post post1 = new(new DateTime(2018, 06, 21), 12, "Traveling to New Zealand", "I'm going to visit this wonderful country!");
Post post2 = new(new DateTime(2018, 07, 28), 5, "Goog night guys", "See you tomorrow");

post1.AddComment(new Comment("Have a nice trip"));
post1.AddComment(new Comment("Wow tha't awesome!"));

post2.AddComment(new Comment("Good night"));
post2.AddComment(new Comment("May the Force be With You"));

Console.WriteLine(post1);
Console.WriteLine(post2);