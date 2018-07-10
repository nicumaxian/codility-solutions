using System;

namespace Codility
{
    public class MaxDoubleSlice
    {
        public int solution(int[] A)
        {
            var maxEndingsLeft = new int[A.Length];
            var maxEndingsRight = new int[A.Length];
            var maxEnding = 0;

            for (int i = 1; i < A.Length - 1; i++)
            {
                maxEndingsLeft[i] = Math.Max(0, maxEndingsLeft[i - 1] + A[i]);
            }

            for (int i = A.Length - 2; i > 0; i--)
            {
                maxEndingsRight[i] = Math.Max(0, maxEndingsRight[i + 1] + A[i]);
            }

            for (int i = 1; i < A.Length - 1; i++)
            {
                maxEnding = Math.Max(maxEnding, maxEndingsLeft[i - 1] + maxEndingsRight[i + 1]);
            }

            return maxEnding;
        }
    }
}