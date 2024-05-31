namespace Fodbold;

public class CountUp
{
    public string TeamName {  get; set; }
    public int? Played { get; set; } = 0;
    public int? Wins { get; set; } = 0;
    public int? Draw { get; set; } = 0;
    public int? Losses { get; set; } = 0;
    public int? GoalsDiff { get; set; } = 0;
    public int? Points { get; set; } = 0;
    public List<string> RecentlyPlayed { get; set; } = new List<string>();

    public CountUp() { }
    //Laver matematikken for point osv.
    public CountUp(TeamPoints teamName, string state, TeamPoints otherTeam)
    {
        TeamName = teamName.TeamName;
        Played++;

        switch (state)
        {
            case "Win":
                Wins += 1;
                Points += 3;
                break;
            case "Loss":
                Losses += 1;
                break;
            case "Draw":
                Draw += 1;
                Points += 1;
                break;
        }
        GoalsDiff += teamName.Goals - otherTeam.Goals;
        RecentlyPlayed.Add(otherTeam.TeamName);
    }
    //tjekker hvem der vinder
    public static (CountUp,CountUp) Validate(TeamPoints team1, TeamPoints team2)
    {
        string stateT1;
        string stateT2;
        if (team1.Goals > team2.Goals)
        {
            stateT1 = "Win";
            stateT2 = "Loss";
        }
        else if (team2.Goals > team1.Goals)
        {
            stateT1 = "Loss";
            stateT2 = "Win";
        }
        else
        {
            stateT1 = "Draw";
            stateT2 = "Draw";
        }
        return (new CountUp(team1, stateT1, team2), new CountUp(team2, stateT2, team1));
    }

}
