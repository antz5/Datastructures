using System;

namespace CircularQueue
{
    public class CircularQueue
    {
        int front;
        public int Count { get; set; }
        int rear;
        int size;
        int[] queue;

        public CircularQueue(int capacity)
        {
            size = capacity;
            queue = new int[size];
            Count = 0;
            front = 0;
            rear = -1;
        }
        private bool IsFull()
        {
            if (Count == size)
                return true;
            return false;
        }

        private bool IsEmpty()
        {
            if (Count == 0)
                return true;
            return false;
        }

        public void Enqueue(int data)
        {
            if (!IsFull())
            {
                rear = (rear + 1) % size;
                queue[rear] = data;
                Count += 1;
            }
            else
                Console.WriteLine("Queue overflow");
        }

        public int Dequeue()
        {
            int data = -1;
            if (!IsEmpty())
            {
                data = queue[front];
                front = (front + 1) % size;
                Count -= 1;
            }
            else
                Console.WriteLine("Queue underflow");

            return data;            
        }

        public void Display()
        {
            int i = front;
            for (int j = 0; j < Count; j++)
            {
                Console.WriteLine(queue[i]);
                i = (i + 1) % size;
            }
        }
    }
}
