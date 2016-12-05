using System;
using System.Collections.Generic;
using System.Numerics;

namespace MaxElement
{
    public class MaxElementInStack
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            StackArray stack = new StackArray(N);
            StackArray TrackingMax = new StackArray(N);
            List<BigInteger> holdMaxElements = new List<BigInteger>();

            while (N > 0)
            {
                string choice = Console.ReadLine();
                string[] input = new string[2];
                if (choice.Contains(" "))
                    input = choice.Split(' ');
                else
                    input[0] = choice;

                switch (int.Parse(input[0]))
                {
                    case 1:
                        stack.push(BigInteger.Parse(input[1]));
                        if (TrackingMax.top == -1 || BigInteger.Parse(input[1]) > TrackingMax.Peek())
                        {
                            TrackingMax.push(BigInteger.Parse(input[1]));
                        }
                        break;
                    case 2:
                        if (stack.Peek() == TrackingMax.Peek())
                        {
                            TrackingMax.pop();
                        }
                        stack.pop();
                        break;
                    case 3:
                        holdMaxElements.Add(TrackingMax.Peek());
                        break;
                }
                N--;
            }
            for (int i = 0; i < holdMaxElements.Count; i++)
            {
                Console.WriteLine(holdMaxElements[i]);
            }
            Console.ReadKey();
        }
    }

    public class StackArray
    {
        public long top = -1;
        BigInteger[] stack = null;
        public StackArray(long size)
        {
            stack = new BigInteger[size];
        }

        public bool isStackEmpty()
        {
            return (top == -1);
        }

        public bool isStackFull()
        {
            return (top == stack.Length - 1);
        }

        public void push(BigInteger data)
        {
            if (!isStackFull())
            {
                stack[++top] = data;
            }
        }
        public BigInteger pop()
        {
            if (isStackEmpty())
            {

                return -1;
            }
            else
            {
                return stack[top--];
            }
        }
        public BigInteger Peek()
        {
            if (isStackEmpty())
            {

                return -1;
            }
            return stack[top];
        }

    }
}
