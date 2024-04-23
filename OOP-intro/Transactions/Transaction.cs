using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_intro.Transactions;

internal class Transaction
{
    internal int ID { get; set; }
    internal int MainTableID { get; set; }
    internal string TransactionType { get; set; }
    internal string LastChanged { get; set; }
    internal decimal Balance { get; set; }
}
