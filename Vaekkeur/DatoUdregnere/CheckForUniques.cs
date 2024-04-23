using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaekkeur.DatoUdregnere;

internal class CheckForUniques
{
    internal bool isUnique(DateTime date)
    {
        string datoFormat = date.ToString("ddMMHHmmss");

        foreach (char i in datoFormat)
        {
            if (datoFormat.IndexOf(i) != datoFormat.LastIndexOf(i))
            {
                return false;
            }
        }
        return true;
    }
}
