using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaekkeur.DatoUdregnere;

internal class findLatestTime
{
    internal string findSenesteDato()
    {
        CheckForUniques check = new CheckForUniques();
        DateTime sidsteDagDecember = new DateTime(DateTime.Now.Year,
            12, 31, 23, 59, 59);

        //Tjekker det samme som i earliest, men den tæller nedad istedet

        for (var dato = sidsteDagDecember; dato.Year == sidsteDagDecember.Year;
            dato = dato.AddSeconds(-1))
        {
            if (check.isUnique(dato))
            {
                return dato.ToString("dd/MM HH:mm:ss");
            }
        }
        throw new Exception("Fejl i program fiks tak.");
    }
}
