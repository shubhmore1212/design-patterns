//Encapsulation

using Basics.Principles.Encapsulation;

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

bankAccount.Withdraw(180);

Console.WriteLine(bankAccount.GetBalance());
