using System.Collections.Generic;

namespace Codility
{
    public class Brackets
    {
        public int solution(string S)
        {
            var stack = new Stack<char>();

            var i = 0;

            while (i < S.Length)
            {
                if (S[i] == '{' || S[i] == '[' || S[i] == '(')
                {
                    stack.Push(S[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    else if (
                        (S[i] == '}' && stack.Peek() == '{')
                        ||
                        (S[i] == ']' && stack.Peek() == '[')
                        ||
                        (S[i] == ')' && stack.Peek() == '(')
                    )
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }

                i++;
            }

            if (stack.Count > 0)
            {
                return 0;
            }

            return 1;
        }
    }
}