using OOP_intro.Objekter;
using OOP_intro.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOP_intro.Repositories;

internal class TransactionRepository : CommonDBModule<CustomerBalance>, IDBRepository<Customer>
{
    private readonly string DBTable = "dbo.Transactions";
    private readonly string Fields = "(MainTableId, TransactionType, LastChanged, Balance)";
    public bool Insert(Customer Input)
    {
        return ExecuteCommand($"insert into {DBTable} {Fields} Values ('" +
            $"");
        throw new NotImplementedException();
    }
    public List<Customer> Select()
    {
        throw new NotImplementedException();
    }
    public List<CustomerBalance> SelectBalance()
    {
        return ExecuteReader<CustomerBalance>("Select * from dbo.UserInformation");
    }
    public bool Update(decimal Input, Customer customer)
    {
        return ExecuteCommand($"Update dbo.UserInformation SET Balance = Balance + {Input} WHERE UserName = '{customer.UserName}'");
    }
}
