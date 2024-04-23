using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_intro;
using OOP_intro.Objekter;

namespace OOP_intro.Repositories;

internal class CustomerRepository : CommonDBModule<Customer>, IDBRepository<Customer>
{
    private readonly string DBTable = "[dbo].[UserInformation]";
    private readonly string Fields = "(FirstName, LastName, Age, UserName, Password, Balance)";
    public bool Insert(Customer Input)
    {
        string cmd = ($"Insert Into {DBTable} {Fields} Values(" +
            $"'{Input.FirstName}', '{Input.LastName}', {Input.Age}, '{Input.UserName}', '{Input.Password}', 0)");
        return ExecuteCommand(cmd);
    }

    public List<Customer> Select()
    {
        var users = ExecuteReader<Customer>($"Select * FROM {DBTable}");
        return users;
    }

    public bool Update(decimal Input, Customer customer)
    {
        throw new NotImplementedException();
    }

}
