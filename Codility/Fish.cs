using System.Collections.Generic;

namespace Codility
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            int count = 0;

            var position = 0;
            var flowingDownstream = new Stack<int>();

            while (position < A.Length)
            {
                while (position < A.Length && B[position] == 1)
                {
                    flowingDownstream.Push(A[position]);
                    position++;
                }

                while (position < A.Length && B[position] == 0)
                {
                    if (flowingDownstream.Count > 0)
                    {
                        if (flowingDownstream.Peek() > A[position])
                        {
                            position++;
                        }
                        else
                        {
                            flowingDownstream.Pop();
                        }
                    }
                    else
                    {
                        count++;
                        position++;
                    }
                }
            }

            count += flowingDownstream.Count;

            return count;
        }
    }
}