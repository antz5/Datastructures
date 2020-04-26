using System;
using System.Collections.Generic;

namespace BalancedBrackets
{
    class Program
    {
        // Complete the isBalanced function below.
        static string isBalanced(string s)
        {
            Stack<char> brackets = new Stack<char>();
            
            for(int i=0;i<s.Length;i++)
            {
                if(s[i] == '{' || s[i] == '[' || s[i] == '(')
                {
                    brackets.Push(s[i]);
                }
                else
                {
                    if(brackets.Count == 0)
                    {
                        return "NO";
                    }
                    else 
                    {
                        char pop = brackets.Pop();
                        if(s[i] == '}' && pop != '{')
                        {
                            return "NO";
                        }
                        else if (s[i] == ']' && pop != '[')
                        {
                            return "NO";
                        }
                        else if (s[i] == ')' && pop != '(')
                        {
                            return "NO";
                        }
                    }
                }
               
            }
            if (brackets.Count == 0)
            {
                return "YES";
            }
            return "NO";
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }
        }
    }
}
