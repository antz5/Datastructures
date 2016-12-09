using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircularLinkedList.Tests
{
    [TestClass]
    public class CircularLinkedListTests
    {
        CircularLList circular = new CircularLList();
        [TestMethod]
        public void AddToEnd()
        {            
            circular.Add(5);
            circular.Add(10);
            circular.Add(15);            
            circular.Add(20);
            circular.Add(25);
            Console.WriteLine("Expected List count = 5 and actual List count = "+circular.Count);
            Assert.AreEqual(circular.Count, 5);
        }

        [TestMethod]
        public void AddToFirst()
        {   
            circular.AddFirst(30);
            circular.AddFirst(40);

            int first = circular.GetFirstNode();
            Assert.AreEqual(40, first);
            Console.WriteLine("Expected: 40 and Actual: " + first);
        }

        [TestMethod]
        public void DisplayAll()
        {
            circular.Display();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();           
        }      

        [TestMethod]
        public void RemoveKey()
        {
            AddToEnd();
            DisplayAll();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            circular.Remove(25);
            DisplayAll();
            Assert.AreEqual(4, circular.Count);
            Console.WriteLine("Expected: 4 and actual List Size: "+circular.Count);
        }
    }
}
