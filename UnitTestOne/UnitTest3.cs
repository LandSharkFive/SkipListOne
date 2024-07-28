using SkipListOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest3
    {
        private Random rnd = new Random();

        [TestMethod]
        public void TestLarge1()
        {
            var a = new SkipList();
            for (int i = 0; i < 1000; i++)
            {
                a.Insert(rnd.Next());
            }

            Assert.AreEqual(1000, a.Count());

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }

    }
}
