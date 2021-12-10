using System.Diagnostics.CodeAnalysis;

namespace MVPConf.ProjectOne.Domain
{
    public interface IPersonService
    {
        Person AddPerson(Person person);
    }
    public class PersonService : IPersonService
    {
        public Person AddPerson(Person person)
        {
            if (person.Name == "")
                return person;

            person.SetId();
            return person;
        }
    }

    [ExcludeFromCodeCoverage]
    public record Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string? Id { get; private set; }

        public string Name { get; init; }

        public void SetId()
        {
            Id = System.Guid.NewGuid().ToString();
        }
    }
}