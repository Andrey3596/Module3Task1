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

        [TestMethod()]
        public void AddVectorTest()
        {
            var vector1 = new Vector(1, 1, 1);
            var vector2 = new Vector(1, 1, 3);

            var vector3 = vector1 + vector2;

            Assert.AreEqual("2 2 4", vector3.Verbose());
        }

        [TestMethod()]
        public void SubVectorTest()
        {
            var vector1 = new Vector(1, 1, 1);
            var vector2 = new Vector(1, 1, 3);

            var vector3 = vector1 - vector2;

            Assert.AreEqual("0 0 -2", vector3.Verbose());
        }
    }
}