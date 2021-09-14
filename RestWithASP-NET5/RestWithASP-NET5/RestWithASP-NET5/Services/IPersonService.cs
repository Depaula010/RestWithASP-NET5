using RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace RestWithASP_NET5.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindBy(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
