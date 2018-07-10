using System;
using System.Collections.Generic;

namespace Codility
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var stack = new Stack<int>();
            var blocks = 0;

            var i = 0;
            while (i < H.Length)
            {
                var current = H[i];
                if (stack.Count == 0 || stack.Peek() < current)
                {
                    stack.Push(current);
                    i++;
                }
                else if (stack.Peek() == current)
                {
                    i++;
                }
                else
                {
                    stack.Pop();
                    blocks++;
                }
            }

            blocks += stack.Count;

            return blocks;
        }
/*

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new int[]
            {
                8, 8, 5, 7, 9, 8, 7, 4, 8
            }));
        }*/
    }
}