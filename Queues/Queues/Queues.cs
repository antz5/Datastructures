using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    /*
        [X] create a method Enqueue to insert an item into the Queue 
        [X] create a method Dequeue to delete an item from the Queue
        [X] create a method IsEmpty to check if the queue is empty
        [X] create a method IsFull to check if the queue is full
        [X] create a property Count to get the number of elements in the queue
    */
    public class Queues
    {
        int front = -1;
        int rear = -1;
        int[] Queue;
        public int Count { get; set; }

        int size;
        public Queues(int capacity)
        {
            size = capacity;
            Queue = new int[size];
        }

        public void Enqueue(int data)
        {
            if (!IsFull())
            {
                Queue[++rear] = data;
                Count += 1;
            }
            else
                Console.WriteLine("Queue Overflow");
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {
                Count -= 1;
                return Queue[front++];
               
            }
            return -1;
        }

        private bool IsEmpty()
        {
            if (rear == -1)
                return true;
            return false;
        }

        private bool IsFull()
        {
            if (front > rear)
                return true;
            else
                return false;
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(Queue[i]);
            }
        }
    }
}
