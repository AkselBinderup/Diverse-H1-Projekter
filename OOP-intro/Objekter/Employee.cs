using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class Employee : Person
{
    internal string JobDescription {  get; private set; }
    internal Employee(string firstName, string lastName, int age, string jobDescription) : base(firstName, lastName, age)
    {
        JobDescription = jobDescription;
    }

    override internal void WriteInfo()
    {
        base.WriteInfo();
        Console.WriteLine(JobDescription);
    }
}
