using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    /*
        [X] create a method to add a node to the list  
        [X] create a method to display the contents of the list      
        [X] create a method to Add to beginning of the list
        [X] create a property to return the number of nodes in the list 
        [X] create a method to Remove a node based on the given key
    */
    public class Node
    {
        public Node next = null;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }

        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);

            }
            else
            {
                next.AddToEnd(data);
            }
        }
        
    }

    public class CircularLList
    {
        Node head = null;
        public int Count { get; set; }

        public void Add(int data)
        {
            
            Node current = head;
            if (head == null)
            {
                head = new Node(data);
                head.next = head;
                Count += 1;
            }
            else
            {
                while (current.next != head)
                {
                    current = current.next;
                }
                
                Node node = new Node(data);
                current.next = node;
                node.next = head;
                Count += 1;
           }
        }

        public void Display()
        {
            Node current = head;
            if (head != null)
            {
                do
                {
                    Console.Write("|" + current.data + "|->|");
                    current = current.next;
                }
                while (current != head);                
            }           
        }

        public void AddFirst(int data)
        {
            Node current = head;
            if (head == null)
            {
                head = new Node(data);
                head.next = head;
                Count += 1;
            }
            else
            {
                Node node = new Node(data);
                Count += 1;
                while (current.next != head)
                {
                    current = current.next;                    
                }
                node.next = head;
                current.next = node;
                head = node;
            }
        }

        public int GetFirstNode()
        {
            if (head != null)
            {
                return head.data;
            }
            else
            {
                Console.WriteLine("The list is empty");
                return -1;
            }
        }

        public int GetLastNode()
        {
            Node current = head;
            if (current == null)
            {                
                Console.WriteLine("The list is empty");
                return -1;
            }
            else
            {
                while (current.next != head)
                {
                    current = current.next;                    
                }
                return current.data;
            }
        }

        public int Remove(int key)
        {
            Node current = head;
            int removedData = 0;
            Node previous = head;
            if (head == null)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                current=head.next;
                while (current != head)
                {
                    if (current.data == key)
                    {
                        removedData = current.data;
                        if (current.next == head)
                        {
                            current.next = null;
                            previous.next = head;
                            Count -= 1;
                            return removedData;                            
                        }
                        else
                        {
                            previous.next = current.next;
                        }
                    }
                    else
                    {
                        previous = current;
                        current = current.next;                        
                    }

                }
            }
            return removedData;
        }
    }
}
