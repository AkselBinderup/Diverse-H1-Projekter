using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Settings;

public class DBSettings
{
    [JsonProperty("ConnectionString")]    
    public string ConnectionString { get; set; }
}
