using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string_using_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 [X]  1) Create an empty stack.
                 [X]  2) One by one push all characters of string to stack.
                 [X]  3) One by one pop all characters from stack and put them back to string.
            */

            string s = Console.ReadLine();
            Stack stack = new Stack(s.Length);

            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }

            //Reverse logic - pop all chars and put them back to string s
            s = "";
            while (stack.top >= 0)
            {
                s += stack.Pop();
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
   
}

public class Stack
{
    public int top = -1;
    char[] array;

    public bool isStackEmpty()
    {
        return top == -1;
    }

    public bool isStackFull()
    {
        return top == array.Length - 1;
    }
    public Stack(int capacity)
    {
        array = new char[capacity];
    }

    public void Push(char data)
    {
        if (!isStackFull())
        {
            array[++top] = data;
        }
    }

    public char Pop()
    {        
        return array[top--];
    }
}