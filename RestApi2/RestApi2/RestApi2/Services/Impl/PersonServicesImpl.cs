using RestApi2.Model;
using System;

namespace RestApi2.Services.Impl
{
    public class PersonServicesImpl : IPersonServices

    {
        public Person FindById(long id)
        {
            var person = MockPerson((int)id);
            return person;
        }


        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                people.Add(MockPerson(i));
            }
            return people;  
        }
        public Person Create(Person person)
        {   
            person.Id = new Random().Next(1,1000);
            return person;
        }
        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // simulate deletion logic
        }
        private Person MockPerson(int i)
        {
            var person = new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "John " + i,
                LastName = "Doe " + i,
                Address = "123 Main St" + i,
                Gender = "Male",
            };
            return person;
        }

    }
}
