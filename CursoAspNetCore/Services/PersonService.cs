using CursoAspNetCore.Model;
using CursoAspNetCore.Services.Interfaces;

namespace CursoAspNetCore.Services
{
    public class PersonService : IPersonService
    {
        private volatile int count;

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
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

 
        Person IPersonService.FindByID(long id)
        {
            return new Person
            {
                Id = IncrementGet(),
                FirstName = "Gustavo",
                LastName = "Landal",
                Address = "Campos Sales",
                Gender = "Masculino"
            };
        }

        Person IPersonService.Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Person Address " + i,
                Gender = "Person Gender " + i
            };
        }

        private long IncrementGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
