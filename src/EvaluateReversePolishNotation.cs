using System;
using System.Collections;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack();
        var index = 0;
        int top = 0;
        int below = 0;
        while (index < tokens.Length)
        {
            switch (tokens[index])
            {
                case "+":
                    top = (int)stack.Pop();
                    below = (int)stack.Pop();
                    stack.Push(below + top);
                    break;
                case "-":
                    top = (int)stack.Pop();
                    below = (int)stack.Pop();
                    stack.Push(below - top);
                    break;
                case "*":
                    top = (int)stack.Pop();
                    below = (int)stack.Pop();
                    stack.Push(below * top);
                    break;
                case "/":
                    top = (int)stack.Pop();
                    below = (int)stack.Pop();
                    stack.Push(below / top);
                    break;
                default:
                    stack.Push(Convert.ToInt32(tokens[index]));
                    break;
            }
            index++;
        }
        return (int)stack.Pop();
    }
}