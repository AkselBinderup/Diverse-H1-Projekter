using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class Customer : Person
{
    internal string UserName { get; set; }
    internal string Password { get; set; }

    internal Customer() : base("", "", 0)
    {
        UserName = "";
        Password = "";
    }
    internal Customer(string firstName, string lastName, int age, string login, string password) : base(firstName, lastName, age)
    {
        UserName = login;
        Password = password;
    }
    internal void WriteInfo()
    {
        Console.WriteLine("Profile: ");
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"Age: {Age}");

    }
}
