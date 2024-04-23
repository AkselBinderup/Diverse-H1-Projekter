namespace ExceptionHandling.Validation;

internal class ValidateNumber
{
    public static bool Validate(int number) => number >= 1 && number <= 4;
}
