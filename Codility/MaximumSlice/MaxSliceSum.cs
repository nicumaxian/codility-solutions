using System;

namespace Codility
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            var maxEnding = 0;
            var maxSlice = Int32.MinValue;

            foreach (var num in A)
            {
                maxEnding = Math.Max(maxEnding + num, num);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}