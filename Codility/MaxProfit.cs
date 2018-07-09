using System;

namespace Codility
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            var min = A[0];
            var maxProfit = Int32.MinValue;

            for (int i = 0; i < A.Length; i++)
            {
                min = Math.Min(A[i], min);
                maxProfit = Math.Max(A[i] - min, maxProfit);
            }

            return maxProfit;
        }
    }
}