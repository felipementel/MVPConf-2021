using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace MVPConf.ProjectOne.Domain.Test
{
    [ExcludeFromCodeCoverage]
    public class PersonTest
    {
        private PersonService _personService;

        public PersonTest()
        {
            _personService = new PersonService();
        }

        [Fact]
        public void Test1()
        {
            // Arrange
            Person person = new("");

            // Act
            var item = _personService.AddPerson(person);

            /// Assert
            Assert.Equal(person, item);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            Person person = new(name: "Felipe");

            // Act
            var item = _personService.AddPerson(person);

            /// Assert
            Assert.NotEmpty(item.Id);
        }
    }
}