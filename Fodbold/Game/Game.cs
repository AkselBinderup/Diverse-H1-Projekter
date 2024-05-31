
namespace Fodbold;

public class Game
{
    public static (CountUp, CountUp) CalculateFinalScore(string team1, string team2, int amountOfGames)
    {
        CountUp team1Score = new CountUp { TeamName = team1 };
        CountUp team2Score = new CountUp { TeamName = team2 };

        for (int i = 0; i < amountOfGames; i++)
        {
            var teamScores1 = TeamPoints.GetTeamPoints(team1);
            var teamScores2 = TeamPoints.GetTeamPoints(team2);
            var bothScores = CountUp.Validate(teamScores1, teamScores2);

            if (i == 0)
            {
                team1Score = bothScores.Item1;
                team2Score = bothScores.Item2;
            }
            else
            {
                (team1Score, team2Score) = Update.UpdateScore((team1Score, team2Score), bothScores);
            }

            Program.logWriter.LogWrite($"Game {i}: {team1} - {bothScores.Item1.Points}, {team2} - {bothScores.Item2.Points}");
        }

        return (team1Score, team2Score);
    }
}
