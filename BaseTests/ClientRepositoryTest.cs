using EK_Collection_Base.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
