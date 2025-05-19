using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Wifi.PlaylistEditor.Repositoriers.Database;

namespace Wifi.PlaylistEditor.Repositoriers.Test
{
    [TestFixture]
    public class MongoRepositoryTest
    {
        private MongoRepository<Person> _fixture;

        [Test]
        public async Task Create()
        {
            var connection = "mongodb://admin:password@localhost:27017";

            _fixture = new MongoRepository<Person>(connection, "person-db", "person-collection");

            var person = new Person
            {
                FirstName = "Max",
                LastName = "Mustermann",
                Age = 42
            };

           await _fixture.CreateAsync(person);

            var result = await _fixture.GetAllAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.GreaterThanOrEqualTo(1));
        }

    }
}
