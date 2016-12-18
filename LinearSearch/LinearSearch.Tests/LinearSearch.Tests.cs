using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinearSearch.Tests
{
    [TestClass]
    public class LinearSearchTests
    {
        LinearSearch search = new LinearSearch();
        [TestMethod]
        public void Search1()
        {
            int[] items = new int[] { 55, 25,36,78,2,49,156,79,125,146,789};
            int key = 789;
            int keyFoundAt = search.Search(items, key);
            Assert.AreEqual(10, keyFoundAt);
            Console.WriteLine("Expected: 10 and Actual: "+keyFoundAt);

        }

        [TestMethod]
        public void Search2()
        {
            int[] items = new int[] { 55, 25, 36, 78, 2, 49, 156, 79, 125, 146, 789 };
            int key = 146;
            int keyFoundAt = search.Search(items, key);
            Assert.AreEqual(9, keyFoundAt);
            Console.WriteLine("Expected: 9 and Actual: " + keyFoundAt);

        }

        [TestMethod]
        public void Search3()
        {
            int[] items = new int[] { 55, 25, 36, 78, 2, 49, 156, 79, 125, 146, 789 };
            int key = 49;
            int keyFoundAt = search.Search(items, key);
            Assert.AreEqual(5, keyFoundAt);
            Console.WriteLine("Expected: 5 and Actual: " + keyFoundAt);

        }

        [TestMethod]
        public void Search4()
        {
            int[] items = new int[] { 55, 25, 36, 78, 2, 49, 156, 79, 125, 146, 789 };
            int key = 1000;
            int keyFoundAt = search.Search(items, key);
            Assert.AreEqual(-1, keyFoundAt);
            Console.WriteLine("Expected: -1 and Actual: " + keyFoundAt);

        }
        [TestMethod]
        public void Search5()
        {
            int[] items = new int[] { 55, 25, 36, 78, 2, 49, 156, 79, 125, 146, 789 };
            int key = 55;
            int keyFoundAt = search.Search(items, key);
            Assert.AreEqual(0, keyFoundAt);
            Console.WriteLine("Expected: 0 and Actual: " + keyFoundAt);

        }
    }


}
