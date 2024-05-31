namespace Fodbold;

public class Update
{
    public static (CountUp, CountUp) UpdateScore((CountUp, CountUp) temp, (CountUp, CountUp) final)
    {
        //opdaterer holdenes statistikker
        Program.logWriter.LogWrite("Starting score update.");

        final.Item1.GoalsDiff += temp.Item1.GoalsDiff;
        final.Item2.GoalsDiff += temp.Item2.GoalsDiff;
        Program.logWriter.LogWrite($"Updated GoalsDiff: Team1 - {final.Item1.GoalsDiff}, Team2 - {final.Item2.GoalsDiff}");

        final.Item1.Played += temp.Item1.Played;
        final.Item2.Played += temp.Item2.Played;
        Program.logWriter.LogWrite($"Updated Played games: Team1 - {final.Item1.Played}, Team2 - {final.Item2.Played}");

        final.Item1.Wins += temp.Item1.Wins;
        final.Item2.Wins += temp.Item2.Wins;
        Program.logWriter.LogWrite($"Updated Wins: Team1 - {final.Item1.Wins}, Team2 - {final.Item2.Wins}");

        final.Item1.Draw += temp.Item1.Draw;
        final.Item2.Draw += temp.Item2.Draw;
        Program.logWriter.LogWrite($"Updated Draws: Team1 - {final.Item1.Draw}, Team2 - {final.Item2.Draw}");

        final.Item1.Points += temp.Item1.Points;
        final.Item2.Points += temp.Item2.Points;
        Program.logWriter.LogWrite($"Updated Points: Team1 - {final.Item1.Points}, Team2 - {final.Item2.Points}");

        final.Item1.Losses += temp.Item1.Losses;
        final.Item2.Losses += temp.Item2.Losses;
        Program.logWriter.LogWrite($"Updated Losses: Team1 - {final.Item1.Losses}, Team2 - {final.Item2.Losses}");

        Program.logWriter.LogWrite("Score update completed.");
        //returnerer to items, det ene hold og det andet opdateret
        return final;
    }
    public static void UpdateTeamPoints(Dictionary<string, CountUp> teamPoints, (CountUp, CountUp) finalScore)
    {
        var (team1Score, team2Score) = finalScore;

        teamPoints[team1Score.TeamName].GoalsDiff += team1Score.GoalsDiff;
        teamPoints[team2Score.TeamName].GoalsDiff += team2Score.GoalsDiff;

        teamPoints[team1Score.TeamName].Played += team1Score.Played;
        teamPoints[team2Score.TeamName].Played += team2Score.Played;

        teamPoints[team1Score.TeamName].Wins += team1Score.Wins;
        teamPoints[team2Score.TeamName].Wins += team2Score.Wins;

        teamPoints[team1Score.TeamName].Draw += team1Score.Draw;
        teamPoints[team2Score.TeamName].Draw += team2Score.Draw;

        teamPoints[team1Score.TeamName].Points += team1Score.Points;
        teamPoints[team2Score.TeamName].Points += team2Score.Points;

        teamPoints[team1Score.TeamName].Losses += team1Score.Losses;
        teamPoints[team2Score.TeamName].Losses += team2Score.Losses;
        //opdaterer statistik i dictionary
    }
}
