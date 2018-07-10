using System;

namespace Codility
{
    public class Ladder
    {
        public int[] solution(int[] A, int[] B)
        {
            var fib = new int[A.Length];
            var result = new int[A.Length];

            fib[0] = 1;

            if (A.Length > 1)
            {
                fib[1] = 2;
            }

            for (int i = 2; i < A.Length; i++)
            {
                fib[i] = (fib[i - 1] + fib[i - 2]) % (int) Math.Pow(2, 30);
            }

            for (int i = 0; i < A.Length; i++)
            {
                result[i] = fib[A[i] - 1] % (int) Math.Pow(2, B[i]);
            }

            return result;
        }
    }
}