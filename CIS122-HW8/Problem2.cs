//Ryan Alghamdi
//April 16

//HW8 problem 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution2
{
    public int CalPoints(string[] ops)
    {
        var stack = new Stack<int>();

        foreach (var op in ops)
        {
            if (op == "+")
                // "+" means add last two scores and push the result
                stack.Push(stack.Peek() + stack.ToArray()[1]);
            else if (op == "D")
                // "D" means double the last score and push it
                stack.Push(stack.Peek() * 2);
            else if (op == "C")
                // "C" means remove the last score
                stack.Pop();
            else
                stack.Push(int.Parse(op));
        }

        int sum = 0;
        foreach (var score in stack)
            sum += score;

        return sum;
    }
}