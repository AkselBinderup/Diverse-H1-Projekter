using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Objekter;

internal class Student : Person
{
    public int Grade { get; private set; }
    internal Student(string firstName, string lastName, int age, int grade) : base(firstName, lastName, age)
    {
        Grade = grade;
    }
    override internal void WriteInfo()
    {
        base.WriteInfo();
        Console.WriteLine(Grade);
    }
}
