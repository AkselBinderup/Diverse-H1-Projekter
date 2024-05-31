namespace Fodbold;

public class Table
{
    public static void Draw(List<CountUp> Values)
    {
        var sortedTeams = Values.OrderByDescending(x => x.Points)
            .ThenByDescending(x=>x.GoalsDiff)
            .ToList();

        //html guden: https://stackoverflow.com/questions/4223815/format-strings-in-console-writeline-method

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("| {0,-20} | {1,-6} | {2,-4} | {3,-4} " +
                          "| {4,-6} | {5,-10} | {6, -6} |", 
            "Team Name", "Played", "Wins", "Draw", "Losses", "Goals Diff", "Points");
        Console.WriteLine("--------------------------------------------------------------------------------");

        foreach (var team in sortedTeams)
        {
            Console.WriteLine("| {0,-20} | {1,-6} | {2,-4} | {3,-4} " +
                              "| {4,-6} | {5,-10} | {6,-6} |",
                team.TeamName,
                team.Played,
                team.Wins,
                team.Draw,
                team.Losses,
                team.GoalsDiff,
                team.Points);
        }

        Console.WriteLine("--------------------------------------------------------------------------------");

    }
}
