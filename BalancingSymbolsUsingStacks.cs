using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Stacks stack = new Stacks(20);
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{' || input[i] == '<')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')' || input[i] == ']' || input[i] == '}' || input[i] == '>')
                {
                    switch (input[i])
                    {
                        case ')':
                            if (stack.Peek() == '(')
                                stack.Pop();
                            break;
                        case ']':
                            if (stack.Peek() == '[')
                                stack.Pop();
                            break;
                        case '}':
                            if (stack.Peek() == '{')
                                stack.Pop();
                            break;
                        case '>':
                            if (stack.Peek() == '<')
                                stack.Pop();
                            break;
                    }
                }
            }
            if(stack.IsStackEmpty())
                Console.WriteLine("The given expression is balanced");
            else
                Console.WriteLine("The given expression is not balanced");
            Console.ReadKey();
        }
    }

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
