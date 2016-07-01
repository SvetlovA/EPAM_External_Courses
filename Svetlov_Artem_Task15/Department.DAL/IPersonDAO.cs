using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public interface IPersonDAO
    {
        void Add(Person person);
        void Edit(Person person);
        void Delete(Person person);
        IEnumerable<Person> GetList();
    }
}
