using Ententando_Heranca.Models;


Account acc1 = new(1001, 100.00, "Ana");
Account acc2 = new SavingsAccount(1002, 100.00, "Marcos", 0.001);

acc1.Withdraw(10);
acc2.Withdraw(10);


Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);



