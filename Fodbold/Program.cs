//Lav en liste af hold

//Lav indeling af hold brackets

//Lav en score generator

//Validering

//

namespace Fodbold;
public class Program
{
    public static LogWriter logWriter = new LogWriter();
    public static void Main()
    {

        try
        {
            //ender med at være 22 kampe da de spiller to gange mod 11 andre hold
            var teamScores = PlayGame.Start(TeamNameReader.GetTeamNames(), 1);
            Table.Draw(teamScores);
            CounterApp.Program.CounterApp();
        }
        catch (Exception ex)
        {
            logWriter.LogWrite(ex.Message);
        }
        Console.ReadLine();
    }
}