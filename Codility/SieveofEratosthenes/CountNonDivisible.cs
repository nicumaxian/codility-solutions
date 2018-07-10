using System;

namespace Codility
{
    public class CountNonDivisible
    {
        public int[] solution(int[] A)
        {
            var maximalNumber = A.Length * 2;
            var counts = new int[maximalNumber + 1];
            var result = new int[A.Length];
            var maxNumber = Int32.MinValue;
            var computed = new bool[maximalNumber + 1];
            var numberCounts = new int[maximalNumber + 1];

            foreach (var i in A)
            {
                numberCounts[i]++;
                maxNumber = Math.Max(maxNumber, i);
            }

            foreach (var i in A)
            {
                counts[i]++;

                if (computed[i])
                {
                    continue;
                }

                var pivot = i + i;
                while (pivot <= maxNumber)
                {
                    counts[pivot] += numberCounts[i];
                    pivot += i;
                }

                computed[i] = true;
            }

            for (int i = 0; i < A.Length; i++)
            {
                result[i] = A.Length - counts[A[i]];
            }

            return result;
        }
    }
}