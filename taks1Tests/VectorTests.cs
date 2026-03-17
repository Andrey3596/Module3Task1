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
            var length = new Vector(10, 1,1)
                ;
            Vector vectorAnswer = new Vector(10, 1, 1);
            Assert.AreEqual(vectorAnswer, length);
        }

        [TestMethod()]
        public void AddVectorTest()
        {
            var vector1 = new Vector(1, 1, 1);
            var vector2 = new Vector(1, 1, 3);

            var vector3 = vector1 + vector2;

            Vector vectorAnswer = new Vector(2, 2, 4);
            Assert.AreEqual(vectorAnswer, vector3);
        }

        [TestMethod()]
        public void SubVectorTest()
        {
            var vector1 = new Vector(1, 1, 1);
            var vector2 = new Vector(1, 1, 3);

            var vector3 = vector1 - vector2;

            Vector vectorAnswer = new Vector(0, 0, -2);
            Assert.AreEqual(vectorAnswer, vector3);
        }

        [TestMethod()]
        public void MulVectorTest()
        {
            var vector1 = new Vector(1, 1, 1);
            var vector2 = new Vector(1, 1, 3);

            var scalarProduct = vector1 * vector2;

            Assert.AreEqual(5, scalarProduct);
        }

        [TestMethod()]
        public void VectorlengthTest()
        {
            var vector1 = new Vector(3, 4, 0);

            Assert.AreEqual(5, vector1.VectorLength());
        }

        [TestMethod()]
        public void VectorProductTest()
        {
            var vector1 = new Vector(2, -3, 1);
            var vector2 = new Vector(4, 5, -2);
            Vector vectorProduct = (vector1/vector2);

            Vector vectorAnswer = new Vector(1, 8, 22);
            Assert.AreEqual(vectorAnswer, vectorProduct);
        }
    }
}