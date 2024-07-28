using SkipListOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestRemove1()
        {
            var a = new SkipList();
            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            for (int i = 0; i < 50; i++)
            {
                a.Remove(i);
            }

            Assert.AreEqual(50, a.Count());

            for (int i = 0; i < 50; i++)
            {
                Assert.IsFalse(a.Contains(i));
            }

            for (int i = 50; i < 100; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }

        [TestMethod]
        public void TestRemove2()
        {
            var a = new SkipList();
            for (int i = 100; i > 0; i--)
            {
                a.Insert(i);
            }

            Assert.AreEqual(100, a.Count());

            for (int i = 1; i < 101; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            for (int i = 100; i > 50; i--)
            {
                a.Remove(i);
            }

            Assert.AreEqual(50, a.Count());

            for (int i = 1; i < 50; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            for (int i = 51; i < 100; i++)
            {
                Assert.IsFalse(a.Contains(i));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }


        [TestMethod]
        public void TestRemove3()
        {
            List<int> list = new List<int>() { 30, 15, 21, 17, 61, 38, 96, 2, 5, 20, 28, 51, 11, 34, 1, 84, 70, 55, 89, 31 };

            List<int> deleted = new List<int>() { 30, 21, 61, 96, 20, 28, 11, 1, 84, 70 };

            var a = new SkipList();
            a.AddRange(list);

            Assert.AreEqual(20, a.Count());

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            foreach (var x in deleted)
            {
                a.Remove(x);
            }

            Assert.AreEqual(10, a.Count());

            foreach (var x in deleted)
            {
                Assert.IsFalse(a.Contains(x));
            }

            Assert.IsTrue(Util.IsSorted(a.ToList()));

            a.Clear();
        }



    }
}
