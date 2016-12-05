using System;

namespace Stacks
{
    public class Stacks
    {
        int top = -1;
        int[] array = null;
        public Stacks(int size)
        {
            array = new int[size];
        }

        //checks if the stack is empty
        public bool IsStackEmpty()
        {
            return (top == -1);
        }

        //checks if the Stack is full
        public bool IsStackFull()
        {
            return (top == array.Length - 1);
        }

        //Insert an item into the stack
        public void Push(int data)
        {
            if (!IsStackFull())
                array[++top] = data;
            else
                Console.WriteLine("Stack Overflow");
        }

        //Deletes an item from the stack and returns the top most item
        public int Pop()
        {
            int item = 0;
            if (!IsStackEmpty())
                item = array[top--];
            else
                Console.WriteLine("Stack Underflow");
            return item;
        }

        //returns the top most element
        public int Peek()
        {
            int item = 0;
            if (!IsStackEmpty())
                item = array[top];
            else
                Console.WriteLine("Stack Underflow");
            return item;
        }
    }
}
