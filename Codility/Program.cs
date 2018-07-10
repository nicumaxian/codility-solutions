using System;
using System.Linq;

namespace Codility
{
    class Program
    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            var max = A[0];
            var sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Math.Abs(A[i]);
                max = Math.Max(A[i], max);
                sum += A[i];
            }

            var count = new int[max + 1];
            var dp = new int[sum + 1];

            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = -1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                count[A[i]]++;
            }

            for (int i = 1; i <= max; i++)
            {
                if (count[i] > 0)
                {
                    for (int j = 0; j < sum; j++)
                    {
                        if (dp[j] >= 0)
                        {
                            dp[j] = count[i];
                        }
                        else if (j >= i && dp[j - i] > 0)
                        {
                            dp[j] = dp[j - i] - 1;
                        }
                    }
                }
            }

            var result = sum;
            for (int i = 0; i < sum / 2 + 1; i++)
            {
                if (dp[i] >= 0)
                {
                    result = Math.Min(result, sum - 2 * i);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new Program().solution(new[]
            {
                //3, 3, 3, 4, 5
                9,8,7
            }));
        }
    }
}