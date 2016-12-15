using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularQueue.Tests
{
    [TestClass]
    public class CircularQueueTests
    {
        CircularQueue queue = new CircularQueue(10);

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
            Console.WriteLine("Expected count : 10 and Actual count: " + queue.Count);
        }

        [TestMethod]
        public void Delete()
        {
            Insert();
            queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();

            if (queue.Count == 9)
            {
                Assert.AreEqual(9, queue.Count);
            }
            Console.WriteLine("Expected count : 9 and Actual count: " + queue.Count);
            queue.Display();
        }

        [TestMethod]
        public void display()
        {
            Insert();
            queue.Display();
        }
    }
}
