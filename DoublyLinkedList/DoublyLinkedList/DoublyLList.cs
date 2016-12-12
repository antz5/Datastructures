using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    
    /*
        [X] create class Node containing properties such as data, previous node and next node
        [X] create a constructor to initialize the data
        [X] create a print method inside the Node class to make a recursive call to the print itself to display nodes
        [X] create a doubly linked list class with a paramless constructor to initialize head and current node
        [X] create a method to Add a node towards the end of the list
        [X] create a method AddFront to add a node at the beginning of the list
        [X] create a method to display all the nodes- This calls the Node class' Print method
        [X] create a method GetNodeAt with the index and the type of node specified (previous, current or next)
        [X] create a method InsertAt with the index and the data as parameters to insert data at the specified index
        [X] create a method Remove with a parameter key, to remove the node of a particular key
        [X] create an Enum for the type of node to fetch while fectching a particular node based on index
        [X] create a property Count which returns the number of nodes present in the list
        [X] create a method Reverse to reverse the doubly linked list
    */

    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node previous { get; set; }

        public Node(int data)
        {
            this.data = data;
        }
        public void Print()
        {
            Console.Write("<-|" + data + "|->"); //Print the nodes in the given string format
            if (next != null)
            {
                next.Print(); //Recursive call to print all nodes until next is null
            }
        }

    }
    public class DoublyLList
    {
        Node head;
        Node current;
        public int Count { get; set; }
        public DoublyLList()
        {
            head = null;
            current = head;
        }

        public void Add(int data)
        {
            
            if (head == null)
            {
                head = new Node(data);
                head.previous = null;
                head.next = null;
                current = head;
                Count += 1;
            }
            else
            {
                while (current.next != null)
                    current = current.next;
                Node node = new Node(data);
                current.next = node;
                node.previous = current;
                Count += 1;
            }
        }

        public void AddFront(int data)
        {
            if (head == null)
                Add(data);
            else
            {
                Node node = new Node(data);
                node.previous = null;
                head.previous = node;
                node.next = head;
                head = node;
                Count += 1;
            }
        }

        public void Display()
        {
            current = head;
            if (head == null)
                Console.WriteLine("The doubly linked list is empty");
            else
            {
                head.Print();                                  
            }
        }       

        public int GetNodeAt(int index, NodeType type)
        {
            int data = -1;
            current = head;
            int listIndex = 0;
            if (head == null)
            {
                Console.WriteLine("The Doubly linked list is empty");
            }
            else 
            {
                while (current != null)
                {
                    if (listIndex == index)
                    {
                        switch (type)
                        {
                            case NodeType.current:
                                return data = current.data;

                            case NodeType.previous:
                                if (current.previous != null)
                                    return data = current.previous.data;
                                else
                                    return data = -1;

                            case NodeType.next:
                                if (current.next != null)
                                {
                                    return data = current.next.data;
                                }
                                else
                                    return data = -1;                           
                        }
                    }               
                    
                    current = current.next;
                    listIndex += 1;                    
                }               
            }
            return -1;
        }

        public void InsertAt(int index, int data)
        {
            int listIndex = 0;

            current = head;
            if (head == null)
            {
                Add(data);
            }
            else
            {
                if (index == 0)
                {
                    Node node = new Node(data);
                    head.previous = node;
                    node.next = head;
                    node.previous = null;
                    head = node;
                    Count += 1;
                }
                else if (index >= Count)
                {
                    index = Count;
                    while (current != null)
                    {
                        if (current.next == null)
                        {
                            Node node = new Node(data);
                            node.next = null;
                            node.previous = current;
                            current.next = node;
                            current = node;
                            Count += 1;
                        }
                        current = current.next;
                    }
                }
                else
                {
                    while (current != null)
                    {
                        if (listIndex == index)
                        {
                            Node node = new Node(data);

                            node.previous = current.previous;
                            current.previous.next = node;
                            node.next = current;
                            current.previous = node;
                            Count += 1;
                        }
                        current = current.next;
                        listIndex += 1;
                    }
                }
            }
        }

        public int Remove(int key)
        {
            int removedData = -1;
            if (head == null)
            {
                Console.WriteLine("The doubly linked list is empty");

            }
            else if (head.data == key)
            {
                removedData = head.data;
                Node temp = head.next;
                temp.previous = null;
                head = temp;
                Count -= 1;
            }
            else
            {
                current = head;
                Node temp = null;
                
                while (current != null)
                {
                    temp = current;

                    if (current.data == key)
                    {
                        removedData = current.data;
                        if (current.next == null)
                        {
                            temp = current.previous;
                            temp.next = null;                            
                        }
                        else
                        {
                            temp = current.previous;
                            temp.next = current.next;
                        }
                        

                        current = temp;
                        Count -= 1;
                        return removedData;
                    }

                    current = current.next;
                }
            }
            return removedData;
        }

        public void Reverse()
        {           
            
            if (head!=null && Count > 1)
            {
                while (current != null)
                {
                    Node temp = current.next;
                    current.next = current.previous;
                    current.previous = temp;
                    if (current.previous == null)
                        head = current;
                    current = current.previous;
                }
            }
            else
            {
                Console.WriteLine("The list is empty");
            }
        }

        public enum NodeType
        {
            previous = 0,
            current = 1,
            next = 2
        }            
    }
}
