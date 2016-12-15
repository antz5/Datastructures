using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Queues.Tests
{
    [TestClass]
    public class QueuesTests
    {
        Queues queue = new Queues(10);
        [TestMethod]
        public void Insert()
        {
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);
            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            queue.Enqueue(35);
            queue.Enqueue(40);
            queue.Enqueue(45);
            queue.Enqueue(50);

            if (queue.Count > 0)
            {
                Assert.AreEqual(10, queue.Count);
            }
            Console.WriteLine("Expected count : 10 and Actual count: "+queue.Count);
        }

        [TestMethod]
        public void Delete()
        {
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            if (queue.Count == 0)
            {
                Assert.AreEqual(0, queue.Count);
            }
            Console.WriteLine("Expected count : 0 and Actual count: " + queue.Count);
        }

        [TestMethod]
        public void display()
        {
            Insert();
            queue.Display();
        }
    }
}
