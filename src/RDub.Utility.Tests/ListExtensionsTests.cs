using System;
using System.Collections.Generic;
using Xunit;

namespace RDub.Utility.Tests
{
    public class ListExtensionsTests
    {
        [Fact]
        public void Clone_NonEmptyList_ReturnsListWithExpectedCount()
        {
            IList<Person> people = new List<Person>
            {
                new Person { FirstName = "George", LastName = "Washington", BirthDate = new DateTime(1722, 2, 22) },
                new Person { FirstName = "John", LastName = "Adams", BirthDate = new DateTime(1735, 10, 30) },
                new Person { FirstName = "Thomas", LastName = "Jefferson", BirthDate = new DateTime(1743, 4, 13) }
            };

            var copy = people.Clone();

            Assert.Equal(people.Count, copy.Count);
        }

        [Fact]
        public void Clone_NonEmptyList_ReturnsListWithExpectedItems()
        {
            IList<Person> people = new List<Person>
            {
                new Person { FirstName = "George", LastName = "Washington", BirthDate = new DateTime(1722, 2, 22) },
                new Person { FirstName = "John", LastName = "Adams", BirthDate = new DateTime(1735, 10, 30) },
                new Person { FirstName = "Thomas", LastName = "Jefferson", BirthDate = new DateTime(1743, 4, 13) }
            };

            var copy = people.Clone();

            for (int i = 0; i < copy.Count; i++)
            {
                Assert.Equal(people[i].FirstName, copy[i].FirstName);
                Assert.Equal(people[i].LastName, copy[i].LastName);
                Assert.Equal(people[i].BirthDate, copy[i].BirthDate);
            }
        }

        [Fact]
        public void Clone_NonEmptyList_ReturnsCopyOfItemsNotReferences()
        {
            IList<Person> people = new List<Person>
            {
                new Person { FirstName = "George", LastName = "Washington", BirthDate = new DateTime(1722, 2, 22) },
                new Person { FirstName = "John", LastName = "Adams", BirthDate = new DateTime(1735, 10, 30) },
                new Person { FirstName = "Thomas", LastName = "Jefferson", BirthDate = new DateTime(1743, 4, 13) }
            };

            var copiedPerson = people.Clone()[0];
            copiedPerson.LastName = "Smith";

            Assert.NotEqual(people[0].LastName, copiedPerson.LastName);
        }
    }
}