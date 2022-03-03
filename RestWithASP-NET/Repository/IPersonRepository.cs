using RestWithASP_NET.Model;
using System.Collections.Generic;

namespace RestWithASP_NET.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);


    }
}
