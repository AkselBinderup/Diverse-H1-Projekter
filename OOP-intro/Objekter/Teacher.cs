using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;
internal class Teacher : Employee
{
    internal string Classes { get; private set; }

    internal Teacher(string firstName, string lastName, int age, string jobDescription, string classes) : 
        base(firstName, lastName, age, jobDescription)
    {
        Classes = classes;
    }
    override internal void WriteInfo()
    {
        base.WriteInfo();
        Console.WriteLine(Classes);
    }
}
