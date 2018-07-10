namespace Codility
{
    public class CountSemiprimes
    {
        
        public int[] solution(int N, int[] P, int[] Q)
        {
            var results = new int[P.Length];
            var isPrime = new bool[N + 1];
            var accumulations = new int[N + 1];

            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i <= N; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i + i; j < N; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            for (int i = 4; i <= N; i++)
            {
                var ok = false;
                for (int j = 2; j*j <= i; j++)
                {
                    if (isPrime[j] && i % j == 0 && isPrime[i / j])
                    {
                        ok = true;
                        break;
                    }
                }

                if (ok)
                {
                    accumulations[i] = accumulations[i - 1] + 1;
                }
                else
                {
                    accumulations[i] = accumulations[i - 1];
                }
            }

            for (int i = 0; i < P.Length; i++)
            {
                results[i] = accumulations[Q[i]] - accumulations[P[i]-1];
            }

            return results;
        }
    }
}