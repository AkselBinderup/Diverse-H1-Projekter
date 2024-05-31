namespace Fodbold;

public class PlayGame
{
    //Det er noget mad chemistry jeg biksede sammen igår kl. 21.54 kommentarerne er for min egen skyld.
    public static List<CountUp> Start(List<string> teamNames, int amountOfGames)
    {
        List<CountUp> listOfPoints = new();
        List<string> remainingTeams = new(teamNames);

        Dictionary<string, CountUp> teamPoints = teamNames.ToDictionary(x => x, x => new CountUp { TeamName = x });

        //bruger en dictionary der laver en værdi af en key som er teamnavnet og et object som er statistik over holdet.
        foreach (var team in teamNames)
        {
            teamPoints[team].RecentlyPlayed = new List<string>(teamNames.Where(x => x != team));
        }
        //Den laver en liste af alle andre teams end den selv. så ved den hvem de skal spille mod.

        Program.logWriter.LogWrite("Game start.");

        //hvert hold spiller mod det andet to gange
        foreach(var team1 in teamNames)
        {

            foreach(var team2 in teamPoints[team1].RecentlyPlayed)
            {
                if(team1 == team2)
                    continue; 
                for (int i = 0; i < amountOfGames; i++) 
                {
                    var finalScore = Game.CalculateFinalScore(team1, team2, amountOfGames);
                    Update.UpdateTeamPoints(teamPoints, finalScore);
                    //opdaterer dictionary
                }
            }
        }

        Program.logWriter.LogWrite("Game end.");
        listOfPoints = teamPoints.Values.ToList();
        return listOfPoints;
    }
}
