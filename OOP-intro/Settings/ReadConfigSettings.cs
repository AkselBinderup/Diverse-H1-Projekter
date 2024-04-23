using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Settings;

internal class ReadConfigSettings
{
    internal static string ReadSettings(string path)
    {
        var lines = File.ReadAllText(path);
        return lines;
    }
}
