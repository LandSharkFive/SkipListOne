using SkipListOne;

namespace UnitTestOne
{

    [TestClass]
    public class UnitTest1
    {
        private Random rnd = new Random();

        [TestMethod]
        public void TestInsert1()
        {
            var a = new SkipList();
            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 0; i < 100;i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }

        [TestMethod]
        public void TestInsert2()
        {
            var a = new SkipList();
            for (int i = 100; i > 0; i--)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 100; i > 0; i--)
            {
                Assert.IsTrue(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }

        [TestMethod]
        public void TestInsert3()
        {
            List<int> list = new List<int>() { 59, 74, 19, 94, 56, 100, 90, 69, 30, 44, 58, 52, 92, 40, 32, 18, 70, 76, 48, 99 };

            var a = new SkipList();
            a.AddRange(list);

            Assert.AreEqual(20, a.Count());

            foreach (var x in list)
            {
                Assert.IsTrue(a.Contains(x));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }


        [TestMethod]
        public void TestInsert4()
        {
            var list = Util.GetRandomList(100);

            var a = new SkipList();
            a.AddRange(list);

            Assert.AreEqual(100, a.Count());

            foreach (var x in list)
            {
                Assert.IsTrue(a.Contains(x));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }



    }
}