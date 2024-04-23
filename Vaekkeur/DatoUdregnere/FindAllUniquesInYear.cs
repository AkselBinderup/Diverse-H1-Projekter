using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Vaekkeur.DatoUdregnere;
internal class findAllUniquesInYear
{
    internal List<string> findAlleDatoer()
    {
        CheckForUniques un = new CheckForUniques();
        DateTime foersteJanuar = new DateTime
            (DateTime.Now.Year,
            1, 1, 0, 0, 0);

        List<string> alleDatoer = new List<string>();
        for (var date = foersteJanuar; date.Year == foersteJanuar.Year;
            date = date.AddSeconds(1))
        {
            //tjekker om hver karakter i strengen er unik
            //returnerer derefter den tidligste dato
            if (un.isUnique(date))
            {
                alleDatoer.Add(date.ToString("dd/MM HH:mm:ss"));
                //date = date.AddDays(1);
            }
        }
        return alleDatoer;
    }
}
