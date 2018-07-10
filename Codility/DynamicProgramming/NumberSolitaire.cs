using System;

namespace Codility
{
    public class NumberSolitaire
    {
        public int solution(int[] A)
        {
            var pastResults = new int[A.Length];

            pastResults[0] = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                pastResults[i] = pastResults[i - 1] + A[i];
                for (int j = 2; j <= 6 && i - j >= 0; j++)
                {
                    pastResults[i] = Math.Max(pastResults[i - j] + A[i], pastResults[i]);
                }
            }

            return pastResults[A.Length - 1];
        }
    }
}