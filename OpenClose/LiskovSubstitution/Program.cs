// See https://aka.ms/new-console-template for more information

using LiskovSubstitution.WrongSolution;

var contract_emp = new ContractEmployee();
//This example give calculateBonus methode for contract base employee. This is vialate LSP
Console.WriteLine(contract_emp.CalculateBonus());
