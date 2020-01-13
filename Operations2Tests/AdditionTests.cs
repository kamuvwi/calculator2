using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Operations2.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly Random rnd = new Random();
        private readonly double[] e = { 2, 1.1, 5.3, 0.7 };
        private readonly int[] f = { 2, 1, 5, 1, 10 };
        
        [TestMethod()]
        public void SumTest()
        {
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(a+b, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest()
        {
            double a = rnd.NextDouble();
            double b = rnd.NextDouble();
            Assert.AreEqual(a+b, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(e[0]+e[1]+e[2]+e[3], Addition.Sum(e));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(19, Addition.Sum(f));
        }
    }
}

namespace Operations2Tests
{
    internal class AdditionTests
    {
    }
}