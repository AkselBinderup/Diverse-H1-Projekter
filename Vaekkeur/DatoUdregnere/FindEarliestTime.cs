using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaekkeur.DatoUdregnere;

internal class findEarliestTime
{
    internal string findTidligsteDato()
    {
        CheckForUniques un = new CheckForUniques();
        //tag den første januar
        DateTime foersteJanuar = new DateTime(DateTime.Now.Year,
            1, 1, 0, 0, 0);

        //iterer gennem sekunder istedet for forvalgte værdier
        //Derefter sørger den for at hvis året ændrer sig (hvis den går over 2024) at den stopper.
        //brug bare c# library med DateTime


        for (var date = foersteJanuar; date.Year == foersteJanuar.Year;
            date = date.AddSeconds(1))
        {
            //tjekker om hver karakter i strengen er unik
            //returnerer derefter den tidligste dato
            if (un.isUnique(date))
            {
                return date.ToString("dd/MM HH:mm:ss");
            }
        }
        throw new Exception("Fejl i program fiks tak.");
    }
}
