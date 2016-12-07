using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLinkedList;
namespace SinglyLinekedListClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddToBeginning(5);
            list.AddToBeginning(10);
            list.AddToBeginning(15);
            list.AddToBeginning(20);
            list.AddToBeginning(25);

            list.AddToEnd(30);
            list.AddToEnd(35);
            list.AddToEnd(40);
            list.AddToEnd(45);
            list.AddToEnd(50);

            Console.WriteLine("The size of the singly linked list is : " + list.Count);
            Console.WriteLine();
            list.DisplayList();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter the key for the node to be removed");
            int key = int.Parse(Console.ReadLine());

            int removed = list.Remove(key);
            if (removed == -1)
                Console.WriteLine("Key not found");
            else
                Console.WriteLine("The key: " + removed + " has been removed from the list");

            Console.WriteLine("The updated list is ");

            list.DisplayList();
            Console.WriteLine("Enter the key where a new data has to be inserted after the key node");
            int keyAfter = int.Parse(Console.ReadLine());

            list.InsertAfter(keyAfter, 100);

            Console.WriteLine("The updated list is ");
            list.DisplayList();

            Console.WriteLine("Enter a key to get the index of the node");
            int keyFind = int.Parse(Console.ReadLine());


            Console.WriteLine("Key found at the " + list.Find(keyFind) + " position");

            list.DisplayList();
            Console.WriteLine("Enter the key where a new data has to be inserted before the key node");
            int keyBefore = int.Parse(Console.ReadLine());
            list.InsertBefore(keyBefore, 200);
            list.DisplayList();
            list.Clear();

            Console.WriteLine();
            Console.WriteLine("------------------------");
            list.Reverse();
            list.DisplayList();
            Console.WriteLine("The size of the list is " + list.Count);

            Console.ReadKey();
        }
    }
}
