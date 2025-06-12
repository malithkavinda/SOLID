// See https://aka.ms/new-console-template for more information

using OpenClose.Calculation;

var S_Acc = new SavingAccount();
S_Acc.InterestCalculation(20);
Console.WriteLine($"Saving Account balace interect : { S_Acc.InterestCalculation(20.00M)}");

var C_Acc = new CurrentAccount();
Console.WriteLine($"Current Account balance interrest : {C_Acc.InterestCalculation(20.00M)}");
