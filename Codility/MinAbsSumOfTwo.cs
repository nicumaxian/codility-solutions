using System;

namespace Codility
{
    public class MinAbsSumOfTwo
    {
        public int solution(int[] A)
        {
            var left = 0;
            var right = A.Length - 1;

            Array.Sort(A);

            var min = Math.Abs(A[left] + A[right]);
            while (left <= right)
            {
                min = Math.Min(Math.Abs(A[left] + A[right]), min);
                if (Math.Abs(A[left]) > A[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return min;
        }
    }
}