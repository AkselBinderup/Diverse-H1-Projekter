using OOP_intro.Objekter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro
{
    internal class LoggedInUI
    {
        
        internal static void ChooseTransfer(Customer customer)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Main Menu:");
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Exit");

                    BankAccount bank = new BankAccount
                        (customer.FirstName, customer.LastName, customer.Age,customer.UserName, customer.Password, default);
                    Console.Write("Please select an option (1-4): ");
                    string choice = Console.ReadLine();
                    string caseTransfer = (int.Parse(choice)-1).ToString();

                    switch (choice)
                    {
                        case "1":
                            Console.Clear();
                            bank.WriteInfo(customer);
                            break;
                        case "2":
                            Console.Clear();
                            bank.ChooseTransferMethod(caseTransfer, customer);
                            break;
                        case "3":
                            Console.Clear();
                            bank.ChooseTransferMethod(caseTransfer, customer);
                            break;
                        case "4":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("...");
                            break;
                    }

                    //customer.WriteInfo();

                    Console.WriteLine("Press any button to continue");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Completed!");
                    Thread.Sleep(1000);
                }
                catch(IndexOutOfRangeException ex) 
                { 
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(2000);
                }
                
            }
        }
        
    }
}
