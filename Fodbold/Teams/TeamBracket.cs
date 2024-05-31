using System.Linq;
namespace Fodbold;

public class TeamBracket
{
    public string? Team1 { get; set; }
    public string? Team2 { get; set; }
    TeamBracket(string team1, string team2)
    {
        Team1 = team1;
        Team2 = team2;
    }
    //Vælger de holde der skal op mod hinanden
    public static TeamBracket SortBracket(List<string> reader)
    {
        Random r = new Random();
        string team1 = "";
        string team2 = "";

        //Opsætter hold mod hinanden
        for (int i = 0; i < 2; i++)
        {
            var teamChosen = reader.ElementAt(r.Next(0, reader.Count));
            reader.Remove(teamChosen);
            if (team1.Equals(""))
                team1 = teamChosen;
            else if (team2.Equals(""))
                team2 = teamChosen;
            else
                break;
        }
        TeamBracket bracket = new(team1, team2);
        return bracket;
    }
}
