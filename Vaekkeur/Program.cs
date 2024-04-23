using Vaekkeur.DatoUdregnere;

namespace Vaekkeur;

public class Program
{
    public static void Main(string[] args)
    {
        findEarliestTime formatTidligst = new findEarliestTime();
        string tidligst = formatTidligst.findTidligsteDato();
        Console.WriteLine("Tidligste tid på året: " + tidligst);

        findLatestTime formatSenest = new findLatestTime();
        string senest = formatSenest.findSenesteDato();
        Console.WriteLine("Seneste tid på året: " + senest);

        findAllUniquesInYear alleDatoer = new findAllUniquesInYear();
        Console.WriteLine($"Antal af disse datoer: {alleDatoer.findAlleDatoer().Count}");

        foreach(var item in alleDatoer.findAlleDatoer())
        {
            Console.WriteLine(item);
        }
    }
}