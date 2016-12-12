using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedList.Tests
{
    [TestClass]
    public class DoublyLListTests
    {
        DoublyLList doubleList = new DoublyLList();
        [TestMethod]
        public void AddNode()
        {
            doubleList.Add(5);
            doubleList.Add(10);
            doubleList.Add(15);
            doubleList.Add(20);
            doubleList.Add(25);

            Assert.AreEqual(5, doubleList.Count);
        }

        [TestMethod]
        public void GetNodeAt()
        {
            AddNode();
            Console.WriteLine("-----------------------------------------------------------");
            int index = 3;
            int current = doubleList.GetNodeAt(index, DoublyLList.NodeType.current);           
            if (current > 0)
                Console.WriteLine("The current node at inde "+index+" is "+ current);
            else
                Console.WriteLine("Node not found");

            int previous = doubleList.GetNodeAt(3, DoublyLList.NodeType.previous);
            if (previous > 0)
                Console.WriteLine("The previous node for the node at index " + index + " is " + previous);
            else
                Console.WriteLine("Node not found");

            int next = doubleList.GetNodeAt(3, DoublyLList.NodeType.next);
            if (next > 0)
                Console.WriteLine("The next node for the node at index " + index + " is " + next);
            else
                Console.WriteLine("Node not found");
        }

        [TestMethod]
        public void AddFront()
        {
            AddNode();

            doubleList.AddFront(40);
            Console.WriteLine("-----------------------------------------------------------");
            doubleList.Display();
        }

        [TestMethod]
        public void Remove()
        {
            doubleList.Remove(120);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Display();
            Console.WriteLine();
            Console.WriteLine("The size of Doubly linked list: " + doubleList.Count);

            doubleList.Remove(25);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Display();
            Console.WriteLine();
            Console.WriteLine("The size of Doubly linked list: " + doubleList.Count);

            doubleList.Remove(20);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Display();
            Console.WriteLine();
            Console.WriteLine("The size of Doubly linked list: " + doubleList.Count);
        }

        [TestMethod]
        public void InsertAt()
        {
           AddNode();

            doubleList.InsertAt(43, 1212121);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Display();
            Console.WriteLine();
            Console.WriteLine("The size of Doubly linked list: " + doubleList.Count);

            doubleList.InsertAt(50, 120);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Display();
            Console.WriteLine();
            Console.WriteLine("The size of Doubly linked list: " + doubleList.Count);
        }

        [TestMethod]
        public void Reverse()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            doubleList.Reverse();
            doubleList.Display();
        }
    }
}
