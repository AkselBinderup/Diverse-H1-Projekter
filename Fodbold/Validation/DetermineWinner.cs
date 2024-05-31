using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold;

public class DetermineWinner
{
    public static (CountUp, CountUp) Please((CountUp,CountUp)finalScore)
    {
        CountUp winnerBracket;
        CountUp loserBracket;
        if (finalScore.Item1.Points > finalScore.Item2.Points)
        {
            winnerBracket = (finalScore.Item1);
            loserBracket = (finalScore.Item2);
        }
        else if (finalScore.Item1.Points < finalScore.Item2.Points)
        {
            winnerBracket = (finalScore.Item1);
            loserBracket = (finalScore.Item2);
        }
        else
        {
            if (finalScore.Item1.GoalsDiff > finalScore.Item2.GoalsDiff)
            {
                winnerBracket = (finalScore.Item1);
                loserBracket = (finalScore.Item2);
            }
            else
            {
                winnerBracket = (finalScore.Item1);
                loserBracket = (finalScore.Item2);
            }
        }
        return (loserBracket, winnerBracket);
    }
}
