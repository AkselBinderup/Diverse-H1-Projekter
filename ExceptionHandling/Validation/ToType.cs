namespace ExceptionHandling.Validation;

internal class ToType<T>
{
    //benytter c# Convert.Changetype til at ændre værdien af input til den generiske type
    //returnerer inputtet der er blevet konverteret og en konfirmation af at det fungerede.
    public static bool MyParse(string input, out T result)
    {
        result = default(T);
        try
        {
            if (input != null)
            {
                if (string.IsNullOrEmpty(input))
                    throw new ArgumentNullException("Inputtet kan ikke være null eller tomt...");

                result = (T)Convert.ChangeType(input, typeof(T));
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Der skete en generel fejl i toType.cs - {ex.Message}");
            throw;
        }

    }
}
