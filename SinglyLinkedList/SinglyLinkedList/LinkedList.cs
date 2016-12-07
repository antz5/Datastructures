using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    /*
        [X] create a Node class with a constructor which initializes the data and next
        [X] create a method to add node to the end of list
        [X] create a method to add node to the beginning of the list
        [X] create a method to print all the nodes in the list
        [X] create a property that returns count/or find the length of the list
        [X] create a method to delete a given key        
        [X] create a method to add node after a given key
        [X] create a method to add node before a given key        
        [X] create a method to return the index of the node based on the given key                
        [X] create a method to clear the list       
        [X] create a method to reverse the list        

    */

    public class Node
    {
        internal int data { get; set; }
        internal Node next { get; set; }        

        internal Node(int data)
        {
           this.data = data;
            this.next = null;
        }

        internal void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data); // if list is empty then create a new node
            }
            else
            {
                next.AddToEnd(data); //recursive call to add the new node at the end
            }
        }
        
        internal void PrintList()
        {
            Console.Write("|"+data+"|->"); //Print the nodes in the given string format
            if (next != null)
            {
                next.PrintList(); //Recursive call to print all nodes until next is null
            }
        }

        private int SizeOfList()
        {
            int count = 0;
            if (next != null)
            {
                while (next != null)
                {
                    count += 1;
                }
            }
            return count;
        }
    }

    public class LinkedList
    {
        Node head;
        public int Count;
        public LinkedList()
        {
            head = null;
            Count = 0;
        }

        public void AddToEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                Count += 1;
            }
            else
            {
                head.AddToEnd(data);
                Count += 1;
            }
        }

        public void AddToBeginning(int data)
        {
            if (head == null)
            {
                head = new Node(data); // if list is empty then create a new node
                Count += 1;
            }
            else
            {
                Node temp = new Node(data); //if the list is not empty then create a temporary node and point to the current node
                temp.next = head;
                head = temp;
                Count += 1;
            }
        }

        public void DisplayList()
        {
            if (head != null)
            {
                head.PrintList();
            }
            else
            {
                Console.WriteLine("The List Contains no data");
            }
        }

        public int Remove(int key)
        {
            int removedData = -1;

            Node current = head;
            Node previous = null;

            if (current != null && current.data == key)
            {
                removedData = current.data;
                head = current.next;
                Count -= 1;
            }
            else
            {
                while (current != null)
                {
                    if (current.data != key)
                    {
                        previous = current;
                        current = current.next;
                    }
                    else
                    {
                        removedData = current.data;
                        current = current.next;
                        previous.next = current;
                        Count -= 1;                                            
                    }
                }
            }
            return removedData;
        }

        public int Find(int key)
        {
            int index = -1;
            Node current = head;
            while (current != null)
            {
                index += 1;
                if (current.data != key)
                {
                    current = current.next;                    
                }
                else
                {
                    return index;
                }            
            }
            return index;
        }

        public void InsertAfter(int key, int data)
        {
            Node current = head;
            Node previous = null;

            if (head == null)
            {
                head = new Node(data);
                Count += 1;
            }
            else
            {
                while (current != null)
                {
                    if (current.data != key)
                    {
                        previous = current;
                        current = current.next;
                    }
                    else
                    {
                        Node node = new Node(data);
                        node.next = current.next;
                        current.next = node;
                        current = current.next;
                        Count += 1;
                    }
                }
            }
        }

        public void InsertBefore(int key, int data)
        {
            Node current = head;
            Node previous = head;            

            if (head == null)
            {
                head = new Node(data);
                Count += 1;
            }
            else
            {               
                while (current != null)
                {                    
                    if (current.data != key)
                    {
                        previous = current;
                        current = current.next;
                    }
                    else
                    {
                        Node node = new Node(data);
                        node.next = current;
                        previous.next = node;
                        current = current.next;
                        Count += 1;
                    }
                }
            }
        }

        public void Clear()
        {
            head = null;
            Count = 0;
        }

        public void Reverse()
        {
            Node current = head;
            Node previous = null;
            Node next = null;
           
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;                  
            }
            head = previous;
        }
    }
}
