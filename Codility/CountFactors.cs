using System;

namespace Codility
{
    public class CountFactors
    {
        public int solution(int N)
        {
            var sqrt = Math.Sqrt(N);
            var count = 0;

            for (int i = 1; i < sqrt; i++)
            {
                if (N % i == 0)
                {
                    count += 2;
                }
            }

            var decimalPart = sqrt - Math.Ceiling(sqrt);
            if (decimalPart == 0)
            {
                count++;
            }

            return count;
        }
    }
}