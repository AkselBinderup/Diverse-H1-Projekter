using ExceptionHandling.Validation;

namespace ExceptionHandling;

internal class Program
{
    static void Main()
    {
        while(true)
        {
            try
            {
                Console.WriteLine("Vælg Tal");
                var input = Console.ReadLine();
                ExceptionHandler.Run(input);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}