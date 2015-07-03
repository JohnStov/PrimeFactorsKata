using NUnit.Framework;

namespace PrimeFactorsKata
{
    public static class Factors
    {
        public static int[] Generate(int n)
        {
            return new int[0];
        }
    }

    [TestFixture]
    public class FactorsTest
    {
        [Test]
        public void TestOne()
        {
            Assert.AreEqual(new [] {1}, Factors.Generate(1));
        }
    }
}

