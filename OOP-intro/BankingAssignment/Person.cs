using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class Person
{
    internal string FirstName { get; private set; }
    internal string LastName { get; private set; }
    internal int Age { get; private set; }

    internal Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    internal virtual void WriteInfo()
    {
        Console.WriteLine(FirstName);
        Console.WriteLine(LastName);
        Console.WriteLine(Age);
       
    }

}
