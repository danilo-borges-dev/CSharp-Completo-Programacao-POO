using Exercicio_95.Entities;

Post post1 = new(new DateTime(2018, 06, 21, 13, 05, 44), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
Post post2 = new(new DateTime(2018, 07, 28, 23, 14, 19), "Good night guys", "See you tomorrow", 5);

post1.AddComment(new Comment("Have a nice trip"));
post1.AddComment(new Comment("Wow that's awesome!"));

post2.AddComment(new Comment("Good night"));
post2.AddComment(new Comment("May the Force with you"));

Console.WriteLine(post1);
Console.WriteLine("\n" + post2);

