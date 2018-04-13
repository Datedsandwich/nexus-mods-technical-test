using NUnit.Framework;

namespace Tests
{
    public class SwapTest
    {
        private Swap swap;

        [SetUp]
        public void Setup()
        {
            swap = new Swap();
        }

        [Test]
        public void shouldSwapValues()
        {
            int a = 3;
            int b = 5;

            swap.swap(ref a, ref b);

            Assert.AreEqual(a, 5);
            Assert.AreEqual(b, 3);
        }
    }
}