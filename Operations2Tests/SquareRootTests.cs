using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operations2.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 9;
        private readonly double c = 44.89;
        private readonly double[] e = { 9.9, 5.5, 11.11 };
        private readonly int[] f = { 4, 25, 100 };

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(3, SquareRoot.Root(a));
        }

        [TestMethod()]
        public void RootDoubleTest()
        {
            Assert.AreEqual(6.7, SquareRoot.Root(c));
        }

        [TestMethod()]
        public void RootDoubleArrayTest()
        {
            double[] y = SquareRoot.Root(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(SquareRoot.Root(e[i]), w);
                i++;
            }
        }

        [TestMethod()]
        public void RootIntArrayTest()
        {
            double[] d = SquareRoot.Root(f);
            int i = 0;

            foreach (double z in d)
            {
                Assert.AreEqual(SquareRoot.Root(f[i]), z);
                i++;
            }
        }
    }
}

namespace Operations2Tests
{
    internal class SquareRootTests
    {
    }
}