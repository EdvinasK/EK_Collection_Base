using EK_Collection_Base.Entities;
using EK_Collection_Base.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BaseTests
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void RetrieveValueTest()
        {
            //Arrange
            var repository = new ClientRepository();
            var expected = 42;

            //Act
            var actual = repository.RetrieveValue("Select ...", 42);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveValueStringTest()
        {
            //Arrange
            var repository = new ClientRepository();
            var expected = "test";

            //Act
            var actual = repository.RetrieveValue("Select ...", "test");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new ClientRepository();
            var expected = 2;

            //Act
            var actual = repository.Retrieve();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void RetrieveObjectTest()
        {
            //Arrange
            var repository = new ClientRepository();
            var expected = new List<Client>
            {
                new Client { Id = 1, Name = "Ross" },
                new Client { Id = 2, Name = "Rachel" }
            };

            //Act
            var actual = repository.Retrieve();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new ClientRepository();
            var expected = new Dictionary<string, Client>
            {
                { "Ross", new Client { Id = 1, Name = "Ross" } },
                { "Rachel", new Client { Id = 2, Name = "Rachel" } }
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
