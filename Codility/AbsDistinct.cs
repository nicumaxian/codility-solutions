using System;

namespace Codility
{
    public class AbsDistinct
    {
        public int solution(int[] A)
        {
            var distincts = 0;
            var left = 0;
            var right = A.Length - 1;
            var lastLeft = 0;
            var lastRight = 0;

            while (left <= right)
            {
                if (left > 0)
                {
                    if (lastLeft == A[left])
                    {
                        left++;
                        continue;
                    }
                }

                if (right < A.Length - 1)
                {
                    if (lastRight == A[right])
                    {
                        right--;
                        continue;
                    }
                }

                if (left == right)
                {
                    distincts++;
                    left++;
                    continue;
                }

                if (A[left] == Int32.MinValue || -A[left] > A[right])
                {
                    lastLeft = A[left];
                    left++;
                    distincts++;
                }
                else if (-A[left] == A[right])
                {
                    lastLeft = A[left];
                    lastRight = A[right];
                    left++;
                    right--;
                    distincts++;
                }
                else
                {
                    lastRight = A[right];
                    right--;
                    distincts++;
                }
            }

            return distincts;
        }
    }
}