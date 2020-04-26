using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Stack<string> stackOfStrings = new Stack<string>();
            string resultString = string.Empty;
            stackOfStrings.Push(resultString);

            int operations = int.Parse(Console.ReadLine());
            for (int i = 0; i < operations; i++)
            {
                string opsToPerform = Console.ReadLine();

                string[] ops = opsToPerform.Split(" ");
                int operationType = int.Parse(ops[0]);

                switch (operationType)
                {
                    case 1:
                        string append = ops[1];
                        resultString += append;
                        stackOfStrings.Push(resultString);
                        break;
                    case 2:
                        int kToDelete = int.Parse(ops[1]);
                        resultString = resultString.Substring(0, resultString.Length - kToDelete);
                        stackOfStrings.Push(resultString);
                        break;
                    case 3:
                        int printKthChar = int.Parse(ops[1]);
                        Console.WriteLine(resultString[printKthChar - 1]);
                        break;
                    default:
                        stackOfStrings.Pop();
                        resultString = stackOfStrings.Peek();
                        break;

                }

            }
        }
    }
}
