using EK.Common;
using EK_Collection_Base.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Client()
            {
                Id = 1,
                Name = "Bob"
            };

            changedItems.Add(customer);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
