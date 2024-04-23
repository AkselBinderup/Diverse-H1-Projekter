using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Transactions;

internal class CustomerBalance
{
    internal string FirstName { get; private set; }
    internal string LastName { get; private set; }
    internal int Age { get; private set; }
    internal string UserName { get; set; }
    internal string Password { get; set; }
    internal decimal Balance { get; set; }
}
