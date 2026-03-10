using Microsoft.VisualStudio.TestTools.UnitTesting;
using taks1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks1.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var length = new Vector(10, 1,1);
            Assert.AreEqual("10 1 1", length.Verbose());
        }
    }
}