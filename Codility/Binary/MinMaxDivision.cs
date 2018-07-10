using System;

namespace Codility
{
    public class MinMaxDivision
    {
        public bool TryCreate(int[] A, int K, int maxBlockSize)
        {
            var lastBlockSize = 0;
            var usedBlocks = 1;

            foreach (var i in A)
            {
                lastBlockSize += i;

                if (lastBlockSize > maxBlockSize)
                {
                    lastBlockSize = i;
                    usedBlocks++;
                }

                if (usedBlocks > K)
                {
                    return false;
                }
            }

            return usedBlocks <= K;
        }

        public int solution(int K, int M, int[] A)
        {
            int min = 0;
            int max = 0;

            foreach (var i in A)
            {
                max += i;
                min = Math.Max(i, min);
            }

            var cnt = 0;

            while (min <= max)
            {
                var mid = (min + max) / 2;

                if (TryCreate(A, K, mid))
                {
                    max = mid - 1;
                    cnt = mid;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return cnt;
        }
    }
}