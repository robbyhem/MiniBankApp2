﻿using MiniBankApp2;
using System.Transactions;

Database db = new Database();
//var omode = new BankUser("omode@sapa.ng", "Nor=thadsgsbsj");
//Console.WriteLine(omode.Password);

////omode comes to the bank with 10,000

//decimal omodesMoney = 10000;
//var moneyLeftToDeposit = omodesMoney - 1000;
//omode.BankAccount = new Account(moneyLeftToDeposit);

//Console.WriteLine($"Omode's account number is {omode.BankAccount.Number} and balance is {omode.BankAccount.Balance:c2}");

while (true)
{
    Console.WriteLine("Account number: ");
    string number = Console.ReadLine();
    var user = db.BankUsers.Where(u => u.BankAccount.Number == number).FirstOrDefault();
    Console.WriteLine($"User with name {user.FirstName} has {user.BankAccount.Balance}");
    Console.ReadKey();
}

Console.WriteLine(Account.Withdrawl());