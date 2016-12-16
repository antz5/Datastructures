using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriorityQueues.Tests
{
    [TestClass]
    public class PriorityQueuesTests
    {
        PriorityQueue.PriorityQueue priority = new PriorityQueue.PriorityQueue(18);
        [TestMethod]
        public void Insert()
        {
            priority.Enqueue(10);
            priority.Enqueue(11);
            priority.Enqueue(18);
            priority.Enqueue(1);
            priority.Enqueue(20);
            priority.Enqueue(3);
            priority.Enqueue(7);
            priority.Enqueue(21);
            priority.Display();

            Assert.AreEqual(8, priority.Count);
            Console.WriteLine("Expected: 8 and actual: "+priority.Count);
        }

        [TestMethod]
        public void Delete()
        {
            Insert();
            Console.WriteLine();
            priority.Dequeue();
            priority.Display();
            Console.WriteLine();
            priority.Dequeue();
            Console.WriteLine();
            priority.Display();
            Console.WriteLine();
            priority.Enqueue(5);
            priority.Display();

            Assert.AreEqual(7, priority.Count);
            Console.WriteLine("Expected: 7 and actual: " + priority.Count);
        }

    }
}
