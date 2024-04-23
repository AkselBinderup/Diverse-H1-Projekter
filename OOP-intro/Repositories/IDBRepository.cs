using OOP_intro.Objekter;

namespace OOP_intro.Repositories;

internal interface IDBRepository <T>
{
    bool Insert(T Input);
    bool Update(decimal Input, Customer customer);
    List<T> Select();
}
