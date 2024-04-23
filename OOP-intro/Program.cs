using OOP_intro.Objekter;
using OOP_intro;

namespace OOP_intro;
internal class Program
{
    static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>();
        UI.Dialogue(customers);
        
        Console.ReadKey();
    }
}

 