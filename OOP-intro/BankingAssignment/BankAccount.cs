using OOP_intro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class BankAccount : Customer
{
    internal decimal Balance { get; private set; }
    internal BankAccount(string firstName, string lastName, int age, string login, string password, decimal balance) : 
    base(firstName, lastName, age, login, password)
    {
        Balance = balance;
    }
    internal void ChooseTransferMethod(string userInput, Customer customer)
    {
        if (userInput != null && userInput == "1" || userInput == "2")
            Console.Clear();
        Console.WriteLine("How much do you wish to transfer? ");
        var transferAmount = decimal.Parse(Console.ReadLine());

        if (userInput == "1")
            Withdraw(transferAmount, customer);
        else if (userInput == "2")
            Deposit(transferAmount, customer);
        else
            throw new InvalidDataException("Fejl i input... ");
    }
    internal void Withdraw(decimal withdrawalAmount, Customer customer)
    {
        Balance = GetBalance(customer);
        if (withdrawalAmount < Balance && withdrawalAmount > 0)
        {
            TransactionRepository repo = new TransactionRepository();

            repo.Update(-withdrawalAmount, customer);
            Balance = Balance - withdrawalAmount;
        }
        else
            throw new IndexOutOfRangeException("Du kan ikke overskride balancen...");
    }
    internal void Deposit(decimal withdrawalAmount, Customer customer)
    {
        TransactionRepository repo = new TransactionRepository();
        Balance = GetBalance(customer);

        repo.Update(withdrawalAmount, customer);
        Balance = Balance + withdrawalAmount;
    }
    internal void WriteInfo(Customer customer)
    {
        Balance = GetBalance(customer);
        base.WriteInfo();
        Console.WriteLine($"Balance: {Balance}kr.");
    }
    internal decimal GetBalance(Customer customer)
    {
        TransactionRepository repo = new TransactionRepository();
        var customers = repo.SelectBalance();
        var user = customers.Where(x => x.UserName.Equals(customer.UserName));
        Balance = user.Select(x => x.Balance).First();
        return Balance;
    }
}
