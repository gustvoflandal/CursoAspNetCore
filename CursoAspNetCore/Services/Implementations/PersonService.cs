using CursoAspNetCore.Model;

namespace CursoAspNetCore.Services.Implementations
{
    public class PersonService : IPersonService
    {
        

        Person IPersonService.Create(Person person)
        {
            return person;
        }

        void IPersonService.Delete(long id)
        {
            
        }

        List<Person> IPersonService.FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = null;
                persons.Add(person);
            }
            return persons;
        }

        Person IPersonService.FindByID(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gustavo",
                LastName = "Landal",
                Address = "Campos Sales",
                Gender = "Masculino"
            };
        }

        Person IPersonService.Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
