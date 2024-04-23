using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Settings;

internal class Settings<ReadIntoSettings>
{
    internal static ReadIntoSettings ReadintoObject(string fromfile)
    {
        var jsonObject = JsonConvert.DeserializeObject<ReadIntoSettings>(fromfile);
        return jsonObject;
    }
}
