//Ryan Alghamdi
//April 16

//HW8 problem 1

using System.Collections.Generic;

namespace CIS122_HW8
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(') stack.Push(')');
                else if (c == '{') stack.Push('}');
                else if (c == '[') stack.Push(']');
                else if (stack.Count == 0 || stack.Pop() != c) return false;
            }

            return stack.Count == 0;
        }
    }
}
