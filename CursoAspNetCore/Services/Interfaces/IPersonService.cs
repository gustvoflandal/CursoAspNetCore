using CursoAspNetCore.Model;

namespace CursoAspNetCore.Services.Interfaces;

public interface IPersonService
{
    Person Create(Person person);
    Person FindByID(long id);
    List<Person> FindAll();
    Person Update(Person person);
    void Delete(long id);

}
