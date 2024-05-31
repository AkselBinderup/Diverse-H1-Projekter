namespace Fodbold;

public class TeamNameReader
{
    public static List<string> GetTeamNames() => [.. File.ReadAllLines("Teams/TeamNames.txt")];
}