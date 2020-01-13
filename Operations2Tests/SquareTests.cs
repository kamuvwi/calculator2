using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations2.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 6;
        private readonly double c = 6.7;
        private readonly double[] e = { 2.2, 5.5, 5.3 };
        private readonly int[] f = { 2, 5, 10 };

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(36, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(44.89, Square.Squared(c));
        }

        [TestMethod()]
        public void SquaredDoubleArrayTest()
        {
            double[] y = Square.Squared(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(Square.Squared(e[i]), w);
                i++;
            }
        }

        [TestMethod()]
        public void SquaredIntArrayTest()
        {
            int[] d = Square.Squared(f);
            int i = 0;

            foreach (int z in d)
            {
                Assert.AreEqual(Square.Squared(f[i]), z);
                i++;
            }
        }
    }
}

namespace Operations2Tests
{
    internal class SquareTests
    {
    }
}