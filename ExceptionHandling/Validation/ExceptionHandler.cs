namespace ExceptionHandling.Validation
{
    internal class ExceptionHandler
    {
        public static bool Run(string input)
        {
            try
            {
                bool homemadeParse = ToType<int>.MyParse(input, out var result);

                if (ValidateNumber.Validate(result) && homemadeParse)
                {
                    Console.WriteLine("Tallet er mellem 1-4");
                    return true;
                }
                else
                {
                    Console.WriteLine("Tallet er ikke mellem 1-4");
                    return false;
                }
            }
            catch
            {
                throw new Exception("Der er sket en fejl med inputtet... [Exception i Run]...");
            }
        }
    }
}
