namespace Fodbold;

public class TeamPoints
{ 
    public string? TeamName { get; set; }
    public int? Goals {  get; set; }

    public TeamPoints(string? teamName, int goals)
    {
        TeamName = teamName;
        Goals = goals;
    }
    public static TeamPoints GetTeamPoints(string team)
    {
        Random r = new();
        return new TeamPoints(team, r.Next(0, 5));
    }
}
