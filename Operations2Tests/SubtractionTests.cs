using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations2.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 6.7;
        private readonly double d = 3.2;
        private readonly double[] e = { 10.5, 2.05, 1.1, 5.3, 1.7 };
        private readonly int[] f = { 20, 2, 1, 5, 1, 10 };

        [TestMethod()]
        public void DifferenceTest()
        {
            Assert.AreEqual(3, Subtraction.Difference(a, b));
        }

        [TestMethod()]
        public void DifferenceDoubleTest()
        {
            Assert.AreEqual(3.5, Subtraction.Difference(c, d));
        }

        [TestMethod()]
        public void DifferenceDoubleArrayTest()
        {
            Assert.AreEqual(-20.65, Subtraction.Difference(e));
        }

        [TestMethod()]
        public void DifferenceIntArrayTest()
        {
            Assert.AreEqual(-39, Subtraction.Difference(f));
        }
    }
}

namespace Operations2Tests
{
    internal class SubtractionTests
    {
    }
}