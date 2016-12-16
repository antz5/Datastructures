using System;

namespace PriorityQueue
{
    public class PriorityQueue
    {
        int front = -1;
        int rear = -1;
        int[] Queue;
        public int Count { get; set; }

        int size;
        public PriorityQueue(int capacity)
        {
            size = capacity;
            Queue = new int[size];
        }

        public void Enqueue(int data)
        {
            if (!IsFull())
            {
                int j = rear;

                while (j >= 0 && data < Queue[j])
                {
                    Queue[j + 1] = Queue[j];
                    j--;
                }
                Queue[j + 1] = data;
                rear += 1;
                Count += 1;
            }
            else
                Console.WriteLine("Queue Overflow");
        }

        public int Dequeue()
        {
            if (!IsEmpty())
            {               
                front += 1;
                Count -= 1;
                return Queue[front];

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
            Console.Write("rear->");
            for (int i = size-1; i >= 0; i--)
            {
                Console.Write(Queue[i]+"->");
            }
            Console.Write("front");
        }
    }
}
