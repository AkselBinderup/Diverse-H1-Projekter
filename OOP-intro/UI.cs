using OOP_intro.Objekter;
using OOP_intro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro;

internal class UI
{
    internal static void Dialogue(List<Customer> customers)
    {
        try
        {
            Console.Clear();
            
            while (true)
            {
                CustomerRepository repo = new CustomerRepository();
                var users = repo.Select();

                Console.WriteLine("Log in [1] \nRegister [2]");
                var choice = int.Parse(Console.ReadLine());
                if (choice != null && choice == 1)
                    Login(users);
                else if (choice != null && choice == 2)
                    customers.Add(Register(users));
                else
                    throw new NullReferenceException("Not a valid choice... ");
                Console.Clear();
            }
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    private static void Login(List<Customer> customers)
    {
        bool checkVariable = true;
        while (checkVariable)
        {
            Console.Clear();
            string name = GetUserInput("Brugernavn: ");
            string password = GetUserInput("Password: ");

            if (name != null && password != null)
            {
                var user = customers
                    .Where(x => x.UserName
                    .Equals(name) && x.Password
                    .Equals(password))
                    .FirstOrDefault();

                if (user != null)
                {
                    LoggedInUI.ChooseTransfer(user);
                    Console.Clear();
                    user.WriteInfo();
                    checkVariable = false;
                }
                else
                {
                    checkVariable = true;
                    Console.Clear();
                    Console.WriteLine("User not found... ");
                    Thread.Sleep(2000);
                }
            }
        }
    }
    private static Customer Register(List<Customer> customers)
    {
        Console.Clear();
        string fornavn = GetUserInput("Fornavn: ");
        string efternavn = GetUserInput("Efternavn: ");
        int alder = int.Parse(GetUserInput("Alder: "));
        string brugernavn = GetUserInput("Brugernavn: ");
        string password = GetUserInput("Password: ");

        if (customers.Where(x => x.UserName.Contains(brugernavn) == false).Any()) {
            Customer customer = new Customer(fornavn, efternavn, alder, brugernavn, password);
            Console.Clear();
            customer.WriteInfo();
            CustomerRepository DB = new CustomerRepository();
            DB.Insert(customer);
            return customer;
        }
        throw new ArgumentException("User already exists... ");
    }
    private static string GetUserInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

}
