using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class Secretary : Employee
{
    internal string Education { get; private set; }
    internal Secretary(string firstName, string lastName, int age, string jobDescription, string education) : base(firstName, lastName, age, jobDescription)
    {
        Education = education;
    }
    override internal void WriteInfo()
    {
        base.WriteInfo();
        Console.WriteLine(Education);
    }
}
