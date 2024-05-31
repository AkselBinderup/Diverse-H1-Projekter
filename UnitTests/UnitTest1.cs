using Fodbold;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;

namespace UnitTests;

public class FodboldTest
{
    [Fact]
    public void CalculateFinalScoreTest2Games()
    {
        string team1 = "TeamA";
        string team2 = "TeamB";
        int amountOfGames = 2;

        var result = Game.CalculateFinalScore(team1, team2, amountOfGames);

        Assert.Equal(team1, result.Item1.TeamName);
        Assert.Equal(team2, result.Item2.TeamName);
        Assert.Equal(amountOfGames, result.Item1.Played);
        Assert.Equal(amountOfGames, result.Item2.Played);
    }
    [Fact]
    public void CalculateFinalScoreTest1Games()
    {
        string team1 = "TeamA";
        string team2 = "TeamB";
        int amountOfGames = 1;

        var result = Game.CalculateFinalScore(team1, team2, amountOfGames);

        Assert.Equal(team1, result.Item1.TeamName);
        Assert.Equal(team2, result.Item2.TeamName);
        Assert.Equal(amountOfGames, result.Item1.Played);
        Assert.Equal(amountOfGames, result.Item2.Played);
    }
    [Fact]
    public void CalculateFinalScoreUpdates()
    {
        string team1 = "TeamA";
        string team2 = "TeamB";
        int amountOfGames = 3;

        var result = Game.CalculateFinalScore(team1, team2, amountOfGames);

        Assert.Equal(team1, result.Item1.TeamName);
        Assert.Equal(team2, result.Item2.TeamName);
        Assert.Equal(amountOfGames, result.Item1.Played);
        Assert.Equal(amountOfGames, result.Item2.Played);
    }
    [Fact]
    public void PlayedGameTests()
    {
        var teamNames = new List<string> { "TeamA", "TeamB", "TeamC" };
        int amountOfGames = 2;
        var result = PlayGame.Start(teamNames, amountOfGames);

        Assert.NotNull(result);
        Assert.Equal(3, result.Count);
        Assert.All(result, x => Assert.Equal(amountOfGames * (teamNames.Count - 1), x.Played));
    }

}
