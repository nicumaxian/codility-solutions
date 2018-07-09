using System;

namespace Codility
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            var sqrt = Math.Sqrt(N);
            var minPerimter = Int32.MaxValue;

            for (int i = 1; i <= sqrt; i++)
            {
                if (N % i == 0)
                {
                    minPerimter = Math.Min(minPerimter, 2 * (i + (N / i)));
                }
            }

            return minPerimter;
        }
    }
}